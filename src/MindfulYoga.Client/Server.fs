module MindfulYoga.Client.Server

open Fable.Remoting.Client
open Fable.Core
open MindfulYoga.Shared.Communication

[<Emit("config.baseUrl")>]
let baseUrl : string = jsNative

module Cmd =
    open Elmish
    
    module OfAsync =
        let eitherResult f args resultMsg =
            let onError (ex:exn) = ex.Message |> ServerError.Exception |> Error |> resultMsg 
            Cmd.OfAsync.either f args resultMsg onError

let newslettersService =
    Remoting.createApi()
    |> Remoting.withRouteBuilder MindfulYoga.Shared.Communication.NewslettersService.RouteBuilder
    |> Remoting.withBaseUrl baseUrl
    |> Remoting.buildProxy<MindfulYoga.Shared.Communication.NewslettersService>
    
let contactMeService =
    Remoting.createApi()
    |> Remoting.withRouteBuilder MindfulYoga.Shared.ContactMe.Communication.ContactMeService.RouteBuilder
    |> Remoting.withBaseUrl baseUrl
    |> Remoting.buildProxy<MindfulYoga.Shared.ContactMe.Communication.ContactMeService>