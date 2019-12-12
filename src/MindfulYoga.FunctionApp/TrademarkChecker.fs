module MindfulYoga.FunctionApp.TrademarkChecker

open System
open Microsoft.Azure.WebJobs
open Microsoft.Extensions.Logging
open FSharp.Control.Tasks.V2
open Microsoft.Azure.WebJobs.Extensions.DurableTask
open System.IO
open System.IO.Compression
open System.Text
open Microsoft.Extensions.Configuration
open MindfulYoga.Libraries.Emails.MailjetProvider

let getUrl (date:DateTime) =
    date.AddDays(-1.).ToString("dd-MM-yyyy")
    |> sprintf "OpendataIPOCZ_TM_DIFF_%s_XML.zip"
    |> sprintf "https://isdv.upv.cz/doc/opendata/tm/%s"

let download (file:string) =
    task {
        let http = new Net.Http.HttpClient()
        return! http.GetStreamAsync(file)
    }

let unzipToString (s:Stream) =
    task {
        use archive = new ZipArchive(s)
        let xmls = archive.Entries |> Seq.filter (fun x -> x.Name.EndsWith(".xml"))
        let contents = ResizeArray<string>()
        for xml in xmls do
            use s = xml.Open()
            use tr = new StreamReader(s, Encoding.UTF8)
            let! text = tr.ReadToEndAsync()
            contents.Add text
        return contents |> Seq.fold (+) ""
    }

[<FunctionName("CheckForNewTrademarksActivity")>]
let checkForNewTrademarksActivity ([<ActivityTrigger>] date: DateTime, log : ILogger) =
    // config
    let cfg = (ConfigurationBuilder()).AddJsonFile("local.settings.json", true).AddEnvironmentVariables().Build()

    let searchPhrases = cfg.["TrademarkPhrases"].Split(",") |> Array.toList
    
    task {
        let url = getUrl date
        log.LogInformation <| sprintf "Trying to download file from %s" url
        let! file = url |> download
        let! content = file |> unzipToString
        let content = content.ToLowerInvariant()
        log.LogInformation <| sprintf "Downloaded %i chars from file" content.Length
        return 
            searchPhrases
            |> List.map (fun x -> x.Trim()) 
            |> List.map (fun x -> x, (content.Contains x && x.Length > 0))
            |> List.filter snd 
            |> List.map fst
    }

[<FunctionName("OnTrademarkFoundActivity")>]
let onTrademarkFoundActivity ([<ActivityTrigger>] input: string list * DateTime, log : ILogger) =
    // config
    let cfg = (ConfigurationBuilder()).AddJsonFile("local.settings.json", true).AddEnvironmentVariables().Build()
    let emailSender = 
        ({ ApiKey = cfg.["MailjetApiKey"]; SecretKey = cfg.["MailjetSecretKey"] } : MailjetEmailConfiguration) 
        |> createEmailSender
    let toAddress = { Email = cfg.["MailTo"]; Name = "" }
    let founds,date = input
    // compose message
    let msg : EmailMessage = 
        { EmailMessage.Empty with 
            Subject = "Trademark found!"
            From = { Email = "info@dzoukr.cz"; Name = "" }
            To = toAddress |> List.singleton
            HtmlMessage = sprintf "<strong>%s at %A</strong>" (founds |> String.concat ", ") date
            PlainTextMessage = sprintf "%s at %A" (founds |> String.concat ", ") date
        }

    task {
        log.LogInformation <| sprintf "Sending email to %s" toAddress.Email
        do! emailSender.Send msg
    }

[<FunctionName("CheckTrademarkOrchestration")>]
let checkTrademarkOrchestration ([<OrchestrationTrigger>] ctx: IDurableOrchestrationContext, log : ILogger) =
    let logInfo i = if not ctx.IsReplaying then log.LogInformation i
    let logWarning i = if not ctx.IsReplaying then log.LogWarning i
    
    task {
        let input = ctx.GetInput<{| Date : DateTime |}>()
        let! founds = ctx.CallActivityAsync<string list>("CheckForNewTrademarksActivity", input.Date)
        match founds with
        | [] -> logInfo "Nothing interesting found"
        | founds ->
            logWarning "Search phrase found!"
            do! ctx.CallActivityAsync("OnTrademarkFoundActivity", (founds, input.Date))
        return ()
    }

[<FunctionName("CheckTrademarkStarter")>]
let checkTrademarkStarter ([<TimerTrigger("0 0 12 * * *")>] timer: TimerInfo, [<DurableClient>] client:IDurableOrchestrationClient, log : ILogger) =
    task {
        let! _ = client.StartNewAsync("CheckTrademarkOrchestration", {| Date = DateTime.UtcNow.Date |})
        return ()
    }