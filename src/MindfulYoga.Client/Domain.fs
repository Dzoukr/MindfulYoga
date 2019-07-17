module MindfulYoga.Client.Domain

open Router

type State = {
    Page : Router.Page
}
with
    static member Init = {
        Page = Page.AdminPage(AdminPage.Users)
    }

type Msg =
    | Todo