module MindfulYoga.FunctionApp.Newsletters.HttpHandlers

open Fable.Remoting.Server
open Fable.Remoting.Giraffe
open MindfulYoga.Shared.Communication

let newslettersService subscribe = 
    {
        Subscribe = subscribe >> Async.AwaitTask
    }

let newslettersHandler log subscribe =
    Remoting.createApi()
    |> Remoting.withRouteBuilder NewslettersService.RouteBuilder
    |> Remoting.fromValue (newslettersService subscribe)
    |> Remoting.buildHttpHandler