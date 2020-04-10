module MindfulYoga.FunctionApp.Web

open Microsoft.Azure.WebJobs
open Microsoft.Extensions.Logging
open Giraffe
open Microsoft.Azure.WebJobs.Extensions.Http
open Microsoft.AspNetCore.Http
open System.Threading.Tasks
open Microsoft.Extensions.Configuration
open MindfulYoga.Libraries.Emails.MailjetProvider
open FSharp.Control.Tasks
open MailChimp.Net

let addToMailchimp (log:ILogger) (apiKey:string) (email:string) =
    task {
        let mailChimpManager = MailChimpManager(apiKey)
        try
            let! lists = mailChimpManager.Lists.GetAllAsync()
            let list = lists |> Seq.head
            let contact = Models.Member(EmailAddress = email, StatusIfNew = MailChimp.Net.Models.Status.Subscribed)
            let! _ = mailChimpManager.Members.AddOrUpdateAsync(list.Id, contact)
            return ()
        with ex -> 
            log.LogError(ex.Message)
            return ()
    }

let webApp log mailchimpKey mailTo mailjetConfig =
    
    let subscribe = addToMailchimp log mailchimpKey
    
    choose [
        Newsletters.HttpHandlers.newslettersHandler log subscribe
        ContactMe.HttpHandlers.contactMeServiceHandler log mailTo mailjetConfig subscribe
    ]

[<FunctionName("Index")>]
let run ([<HttpTrigger (AuthorizationLevel.Anonymous, Route = "{*any}")>] req : HttpRequest, context : ExecutionContext, log : ILogger) =
    let cfg = (ConfigurationBuilder()).AddJsonFile("local.settings.json", true).AddEnvironmentVariables().Build()
    let hostingEnvironment = req.HttpContext.GetHostingEnvironment()
    hostingEnvironment.ContentRootPath <- context.FunctionAppDirectory
    let func = Some >> Task.FromResult
    let mailjetCfg = ({ ApiKey = cfg.["MailjetApiKey"]; SecretKey = cfg.["MailjetSecretKey"] } : MailjetEmailConfiguration) 
    webApp log cfg.["MailchimpApiKey"] cfg.["MailTo"] mailjetCfg func req.HttpContext