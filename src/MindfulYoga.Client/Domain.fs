module MindfulYoga.Client.Domain

open Router

type State = {
    Page : Router.Page
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
    }

type Msg =
    | EmailChanged of string
    | Subscribe
    | Subscribed