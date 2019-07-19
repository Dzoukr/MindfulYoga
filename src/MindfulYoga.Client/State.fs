module MindfulYoga.Client.State

open Elmish
open Fable.Import
open MindfulYoga.Client.Domain
open System
open Elmish.UrlParser
open Elmish.Navigation
open Router

let private removeSlash (s:string) = s.TrimStart([|'/'|])
let inline private s p = p |> removeSlash |> s

let pageParser: Parser<Page -> Page, Page> =
    oneOf [
        // map (AuthPage(ForgottenPassword)) (s ForgottenPassword.Path)
        // map (AuthPage(Login)) (s Login.Path)
        // map (AuthPage(Registration)) (s Registration.Path)
        // map ((fun (x:string) -> Guid(x)) >> AccountActivation >> AuthPage) (s "/accountActivation" </> str)
        // map ((fun (x:string) -> Guid(x)) >> ResetPassword >> AuthPage) (s "/resetPassword" </> str)
        // map (AdminPage(Users)) (s Users.Path)
        // map (AdminPage(Lessons)) (s Lessons.Path)
        map AboutMe (s Page.AboutMe.Path)
        map MindfulYoga (s Page.MindfulYoga.Path)
        map Retreat (s Page.Retreat.Path)
        map Contact (s Page.Contact.Path)
        // map MyLessons (s MyLessons.Path)
    ]

let urlUpdate (result: Option<Page>) state =
    match result with
    | None -> state, Navigation.newUrl Router.Page.Default.Path
    | Some page -> { state with Page = page }, Cmd.none
        

let init result =
    urlUpdate result State.Init
 
let update (msg : Msg) (state : State) : State * Cmd<Msg> =
    state, Cmd.none