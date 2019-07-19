module MindfulYoga.Client.Domain

open Router

type State = {
    Page : Router.Page
}
with
    static member Init = {
        Page = Page.Default
    }

type Msg =
    | Todo