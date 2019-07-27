module MindfulYoga.Client.Domain

open Router

type State = {
    Page : Router.Page
    BurgerMenuVisible : bool

    IsLoading : bool
    IsSubscribed : bool
    SubscribeEmail : string
}
with
    static member Init = {
        Page = Page.Default
        IsLoading = false
        IsSubscribed = false
        SubscribeEmail = ""
        BurgerMenuVisible = false
    }

type Msg =
    | ToggleBurgerMenu
    | EmailChanged of string
    | Subscribe
    | Subscribed