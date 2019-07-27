module MindfulYoga.FunctionApp.Web

open Microsoft.Azure.WebJobs
open Microsoft.Extensions.Logging
open Giraffe
open Microsoft.Azure.WebJobs.Extensions.Http
open Microsoft.AspNetCore.Http
open FSharp.Control.Tasks.V2
open System.Threading.Tasks
open MindfulYoga.Shared.Communication
open Microsoft.Extensions.Configuration
open System
open Fable.Remoting.Server
open Fable.Remoting.Giraffe

let myApi (mailchimpApiKey:string) = 
    {
        Subscribe = (fun email ->
            let mailChimpManager = MailChimp.Net.MailChimpManager(mailchimpApiKey)
            task {
                let! lists = mailChimpManager.Lists.GetAllAsync()
                let list = lists |> Seq.head
                let contact = new MailChimp.Net.Models.Member(EmailAddress = email, StatusIfNew = MailChimp.Net.Models.Status.Subscribed)
                let! _ = mailChimpManager.Members.AddOrUpdateAsync(list.Id, contact)
                return ()
            } |> Async.AwaitTask
        )
    }

let webApp mailchimpApiKey =
    Remoting.createApi()
    |> Remoting.withRouteBuilder NewslettersAPI.RouteBuilder
    |> Remoting.fromValue (myApi mailchimpApiKey)
    |> Remoting.buildHttpHandler

[<FunctionName("Index")>]
let run ([<HttpTrigger (AuthorizationLevel.Anonymous, Route = "{*any}")>] req : HttpRequest, context : ExecutionContext, log : ILogger) =
    
    let cfg = (ConfigurationBuilder()).AddJsonFile("local.settings.json", true).AddEnvironmentVariables().Build()

    let hostingEnvironment = req.HttpContext.GetHostingEnvironment()
    hostingEnvironment.ContentRootPath <- context.FunctionAppDirectory
    let func = Some >> Task.FromResult
    task {
        let! _ = (webApp cfg.["MailchimpApiKey"]) func req.HttpContext
        req.HttpContext.Response.Body.Flush() //workaround https://github.com/giraffe-fsharp/Giraffe.AzureFunctions/issues/1
    } :> Task    