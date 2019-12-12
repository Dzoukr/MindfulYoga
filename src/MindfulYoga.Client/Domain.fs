module MindfulYoga.Client.Domain

open Router
open MindfulYoga.Shared.Validation

type State = {
    Page : Router.Page
    BurgerMenuVisible : bool

    IsLoading : bool
    IsSubscribed : bool
    SubscribeEmail : string
    
    EmailForm : MindfulYoga.Shared.ContactMe.Domain.EmailForm
    EmailFormValidationErrors : ValidationError list
    IsSending : bool
}
with
    static member Init = {
        Page = Page.Default
        IsLoading = false
        IsSubscribed = false
        SubscribeEmail = ""
        BurgerMenuVisible = false
        EmailForm = { Name = ""; Email = ""; Phone = ""; Message = "" }
        EmailFormValidationErrors = []
        IsSending = false
    }

type Msg =
    | ToggleBurgerMenu
    | EmailChanged of string
    | Subscribe
    | Subscribed
    | EmailFormChanged of MindfulYoga.Shared.ContactMe.Domain.EmailForm
    | SendEmailForm
    | EmailFormSent of MindfulYoga.Shared.Communication.ServerResult<unit>