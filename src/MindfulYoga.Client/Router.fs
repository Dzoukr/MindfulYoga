module MindfulYoga.Client.Router

open System
open Elmish.Navigation
open Fable.Import
open Fable.Core.JsInterop
open Browser.Types
open Elmish.UrlParser

type Page =
    | AboutMe
    | MindfulYoga
    | Retreat
    | Lessons
    | IndividualLessons
    | CompanyLessons
    | Contact
    | SriLanka2020
    | Workshops
    with
        member x.Path = 
            match x with
            | AboutMe -> "/o-mne"
            | MindfulYoga -> "/mindful-yoga"
            | Retreat -> "/retreat"
            | Lessons -> "/lekce"
            | IndividualLessons -> "/individualni-lekce"
            | CompanyLessons -> "/joga-pro-firmy"
            | Contact -> "/kontakt"
            | SriLanka2020 -> "/srilanka2020"
            | Workshops -> "/workshopy"
        static member Default = MindfulYoga


let private removeSlash (s:string) = s.TrimStart([|'/'|])
let inline private s p = p |> removeSlash |> s

let pageParser: Parser<Page -> Page, Page> =
    oneOf [
        map AboutMe (s Page.AboutMe.Path)
        map MindfulYoga (s Page.MindfulYoga.Path)
        map Retreat (s Page.Retreat.Path)
        map Lessons (s Page.Lessons.Path)
        map IndividualLessons (s Page.IndividualLessons.Path)
        map CompanyLessons (s Page.CompanyLessons.Path)
        map Contact (s Page.Contact.Path)
        map SriLanka2020 (s Page.SriLanka2020.Path)
        map Workshops (s Page.Workshops.Path)
    ]

let goToUrl (e: MouseEvent) =
    e.preventDefault()
    let href = !!e.currentTarget?href
    Navigation.newUrl href |> List.map (fun f -> f ignore) |> ignore