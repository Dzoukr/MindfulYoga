namespace MindfulYoga.Libraries.Emails

open System
open System.Threading.Tasks

type Address = {
    Email : string
    Name : string
}

type EmailMessage = {
    From: Address
    To : Address list
    Cc : Address list
    Bcc : Address list
    Subject : string
    HtmlMessage : string
    PlainTextMessage : string
}
with
    static member Empty = {
        From = { Name = ""; Email = ""}
        To = []
        Cc = []
        Bcc = []
        Subject = ""
        HtmlMessage = ""
        PlainTextMessage = ""
    }

type EmailProvider = {
    Send : EmailMessage -> Task<unit>
}