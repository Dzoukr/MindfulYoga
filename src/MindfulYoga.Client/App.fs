module MindfulYoga.Client.App

open Elmish
open Elmish.React
open Fable.React
open Fable.React.Props
open Fulma
open Thoth.Json

module Server =

    open MindfulYoga.Shared.Communication
    open Fable.Remoting.Client
    open Fable.Core

    [<Emit("config.baseUrl")>]
    let baseUrl : string = jsNative
    let api : API =
      Remoting.createApi()
      |> Remoting.withRouteBuilder API.RouteBuilder
      #if !DEBUG
      |> Remoting.withBaseUrl baseUrl
      #endif
      |> Remoting.buildProxy<API>

open Elmish
open Elmish.React
open Elmish.UrlParser
open Elmish.Navigation

#if DEBUG
open Elmish.Debug
open Elmish.HMR
#endif

Program.mkProgram State.init State.update View.render
|> Program.toNavigable (parsePath Router.pageParser) State.urlUpdate
#if DEBUG
|> Program.withConsoleTrace
#endif
|> Program.withReactBatched "elmish-app"
#if DEBUG
|> Program.withDebugger
#endif
|> Program.run