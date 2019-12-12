module MindfulYoga.FunctionApp.Web

open Microsoft.Azure.WebJobs
open Microsoft.Extensions.Logging
open Giraffe
open Microsoft.Azure.WebJobs.Extensions.Http
open Microsoft.AspNetCore.Http
open System.Threading.Tasks
open Microsoft.Extensions.Configuration
open MindfulYoga.Libraries.Emails.MailjetProvider

let webApp log mailchimpKey mailTo mailjetConfig =
    choose [
        Newsletters.HttpHandlers.newslettersHandler log mailchimpKey
        ContactMe.HttpHandlers.contactMeServiceHandler log mailTo mailjetConfig
    ]

[<FunctionName("Index")>]
let run ([<HttpTrigger (AuthorizationLevel.Anonymous, Route = "{*any}")>] req : HttpRequest, context : ExecutionContext, log : ILogger) =
    let cfg = (ConfigurationBuilder()).AddJsonFile("local.settings.json", true).AddEnvironmentVariables().Build()
    let hostingEnvironment = req.HttpContext.GetHostingEnvironment()
    hostingEnvironment.ContentRootPath <- context.FunctionAppDirectory
    let func = Some >> Task.FromResult
    let mailjetCfg = ({ ApiKey = cfg.["MailjetApiKey"]; SecretKey = cfg.["MailjetSecretKey"] } : MailjetEmailConfiguration) 
    webApp log cfg.["MailchimpApiKey"] cfg.["MailTo"] mailjetCfg func req.HttpContext