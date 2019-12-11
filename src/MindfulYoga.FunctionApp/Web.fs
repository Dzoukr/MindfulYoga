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
open FSharp.Control.Tasks

let subscribe (log:ILogger) (mailchimpApiKey:string) email =
    task {
        let mailChimpManager = MailChimp.Net.MailChimpManager(mailchimpApiKey)
        try
            let! lists = mailChimpManager.Lists.GetAllAsync()
            let list = lists |> Seq.head
            let contact = new MailChimp.Net.Models.Member(EmailAddress = email, StatusIfNew = MailChimp.Net.Models.Status.Subscribed)
            let! _ = mailChimpManager.Members.AddOrUpdateAsync(list.Id, contact)
            return ()
        with ex -> 
            log.LogError(ex.Message)
            return ()
    }

let myApi (log:ILogger) (mailchimpApiKey:string) = 
    {
        Subscribe = subscribe log mailchimpApiKey >> Async.AwaitTask
    }

let webApp log mailchimpApiKey =
    Remoting.createApi()
    |> Remoting.withRouteBuilder NewslettersAPI.RouteBuilder
    |> Remoting.fromValue (myApi log mailchimpApiKey)
    |> Remoting.buildHttpHandler

open FSharp.Control.Tasks

[<FunctionName("Index")>]
let run ([<HttpTrigger (AuthorizationLevel.Anonymous, Route = "{*any}")>] req : HttpRequest, context : ExecutionContext, log : ILogger) =
    let cfg = (ConfigurationBuilder()).AddJsonFile("local.settings.json", true).AddEnvironmentVariables().Build()
    let hostingEnvironment = req.HttpContext.GetHostingEnvironment()
    hostingEnvironment.ContentRootPath <- context.FunctionAppDirectory
    let func = Some >> Task.FromResult
    webApp log cfg.["MailchimpApiKey"] func req.HttpContext