module MindfulYoga.Client.State

open Elmish
open Fable.Import
open MindfulYoga.Client.Domain
open System

open Elmish.Navigation
open Router

let urlUpdate (result: Option<Page>) state =
    match result with
    | None -> state, Navigation.newUrl Router.Page.Default.Path
    | Some page -> { state with Page = page }, Cmd.none
        

let init result =
    urlUpdate result State.Init
 
let update (msg : Msg) (state : State) : State * Cmd<Msg> =
    state, Cmd.none