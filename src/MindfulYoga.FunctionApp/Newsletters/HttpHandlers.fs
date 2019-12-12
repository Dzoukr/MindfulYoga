module MindfulYoga.FunctionApp.Newsletters.HttpHandlers

open Microsoft.Extensions.Logging
open FSharp.Control.Tasks
open Fable.Remoting.Server
open Fable.Remoting.Giraffe
open MindfulYoga.Shared.Communication

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

let newslettersService (log:ILogger) (mailchimpApiKey:string) = 
    {
        Subscribe = subscribe log mailchimpApiKey >> Async.AwaitTask
    }

let newslettersHandler log mailchimpApiKey =
    Remoting.createApi()
    |> Remoting.withRouteBuilder NewslettersService.RouteBuilder
    |> Remoting.fromValue (newslettersService log mailchimpApiKey)
    |> Remoting.buildHttpHandler