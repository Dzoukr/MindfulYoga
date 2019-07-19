module MindfulYoga.Client.Router

open System
open Elmish.Navigation
open Fable.Import
open Fable.Core.JsInterop
open Browser.Types

type Page =
    | AboutMe
    | MindfulYoga
    | Retreat
    | Contact
    with
        member x.Path = 
            match x with
            | AboutMe -> "/o-mne"
            | MindfulYoga -> "/mindful-yoga"
            | Retreat -> "/retreat"
            | Contact -> "/kontakt"
        static member Default = MindfulYoga


let goToUrl (e: MouseEvent) =
    e.preventDefault()
    let href = !!e.currentTarget?href
    Navigation.newUrl href |> List.map (fun f -> f ignore) |> ignore