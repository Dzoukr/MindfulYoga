module MindfulYoga.Client.App

open Elmish
open Elmish.React
open Fable.React
open Fable.React.Props
open Fulma
open Thoth.Json

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