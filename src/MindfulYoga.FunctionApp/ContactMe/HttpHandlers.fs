module MindfulYoga.FunctionApp.ContactMe.HttpHandlers

open Microsoft.Extensions.Logging
open FSharp.Control.Tasks
open Fable.Remoting.Server
open Fable.Remoting.Giraffe
open MindfulYoga.Libraries.Emails.MailjetProvider
open MindfulYoga.Shared.ContactMe.Communication
open MindfulYoga.Shared.ContactMe.Domain

let sendEmail (log:ILogger) mailTo (configuration:MailjetEmailConfiguration) (email:EmailForm) =
    let emailSender = createEmailSender configuration
    let toAddress = { Email = mailTo; Name = "" }
    // compose message
    let htmlMsg =
        sprintf "<strong>Jméno:</strong> %s<br/>" email.Name
        + sprintf "<strong>Email:</strong> %s<br/>" email.Email
        + sprintf "<strong>Telefon:</strong> %s<br/>" email.Phone
        + sprintf "<strong>Zpráva:</strong> %s<br/>" email.Message
    
    let msg : EmailMessage = 
        { EmailMessage.Empty with 
            Subject = "Zpráva z kontaktního formuláře"
            From = { Email = mailTo; Name = "" }
            To = toAddress |> List.singleton
            HtmlMessage = htmlMsg
            PlainTextMessage = htmlMsg
        }

    task {
        log.LogInformation("Sending {email} email to {address}", msg, toAddress.Email)
        let! _ = emailSender.Send msg
        log.LogInformation "Email successfully sent"
        return Ok ()
    }
    

let contactMeService (log:ILogger) mailTo config : ContactMeService = 
    {
        SendEmail = sendEmail log mailTo config >> Async.AwaitTask
    }

let contactMeServiceHandler log mailTo config =
    Remoting.createApi()
    |> Remoting.withRouteBuilder ContactMeService.RouteBuilder
    |> Remoting.fromValue (contactMeService log mailTo config)
    |> Remoting.buildHttpHandler