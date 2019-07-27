module MindfulYoga.Client.Server

open Fable.Remoting.Client
open Fable.Core

[<Emit("config.baseUrl")>]
let baseUrl : string = jsNative

let authAPI =
    Remoting.createApi()
    |> Remoting.withRouteBuilder MindfulYoga.Shared.Communication.NewslettersAPI.RouteBuilder
    |> Remoting.withBaseUrl baseUrl
    |> Remoting.buildProxy<MindfulYoga.Shared.Communication.NewslettersAPI>