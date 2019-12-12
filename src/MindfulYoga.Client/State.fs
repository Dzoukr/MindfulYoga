module MindfulYoga.Client.State

open Elmish
open Fable.Import
open MindfulYoga.Client.Domain
open System

open Elmish.Navigation
open Router
open MindfulYoga.Shared.ContactMe

let urlUpdate (result: Option<Page>) state =
    match result with
    | None -> state, Navigation.newUrl Router.Page.Default.Path
    | Some page -> { state with Page = page }, Cmd.none
        

let init result =
    urlUpdate result State.Init

module StateHandlers =
    open MindfulYoga.Shared.Communication
    open MindfulYoga.Shared.Validation
    open MindfulYoga.Client.SharedViews

    let handleValidated
        (onSuccess:'a -> 'model * Cmd<_>)
        (onErrorModel:'model)
        (onValidationError:'model -> ValidationError list -> 'model)
        (res:ServerResult<'a>) =
            match res with
            | Ok v -> v |> onSuccess
            | Error error ->
                let cmd = error |> ErrorViews.showError
                let model =
                    match error with
                    | Validation errs -> onValidationError onErrorModel errs
                    | _ -> onErrorModel
                model, cmd
                
    let handle onSuccess onErrorModel res = handleValidated onSuccess onErrorModel (fun x y -> x) res  

open Elmish.Toastr
open Server
open StateHandlers

let update (msg : Msg) (model : State) : State * Cmd<Msg> =
    match msg with
    | ToggleBurgerMenu -> { model with BurgerMenuVisible = not model.BurgerMenuVisible}, Cmd.none
    | EmailChanged v -> { model with SubscribeEmail = v }, Cmd.none
    | Subscribe -> { model with IsLoading = true }, Cmd.OfAsync.perform newslettersService.Subscribe model.SubscribeEmail (fun _ -> Subscribed)
    | Subscribed -> { model with IsLoading = false; IsSubscribed = true }, Cmd.none
    | EmailFormChanged v ->
        let validation = Validation.validateForm(v)
        { model with EmailForm = v; EmailFormValidationErrors = validation }, Cmd.none
    | SendEmailForm ->
        let validationErrors = Validation.validateForm(model.EmailForm)
        let model = { model with EmailFormValidationErrors = validationErrors }
        match validationErrors with
        | [] -> { model with IsSending = true }, Cmd.OfAsync.eitherResult contactMeService.SendEmail model.EmailForm EmailFormSent
        | _ -> model, Cmd.none
    | EmailFormSent res ->
        let onSuccessToast =
            Toastr.message "Email úspěšně odeslán!"
            |> Toastr.success
        
        let onSuccess _ = { model with IsSending = false; EmailForm = { Name = ""; Email = ""; Phone = ""; Message = "" } }, onSuccessToast
        let onError = { model with IsSending = false }
        let onValidationError m e = { m with EmailFormValidationErrors = e } 
        res |> handleValidated onSuccess onError onValidationError