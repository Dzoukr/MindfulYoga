module MindfulYoga.Client.View

open Domain
open Fulma
open Fable.React
open Fable.React.Props
open Fable.Core.JsInterop

let menu (state:State) dispatch =
    let burgerMenuClass = if state.BurgerMenuVisible then "is-active" else ""
    let item (p:Router.Page) title =
        let isActive = p = state.Page
        Navbar.Item.a [ Navbar.Item.Option.IsActive isActive; Navbar.Item.Option.Props [ Href p.Path; OnClick Router.goToUrl ] ] [ str title]

    Navbar.navbar [ Navbar.Option.IsTransparent ] [
        Navbar.Brand.div [] [
            Navbar.Item.a [ Navbar.Item.Option.Props [ Href Router.AboutMe.Path; OnClick Router.goToUrl ] ] [
                img [ Src "img/logo.png" ]
            ]
            a [ Class ("navbar-burger " + burgerMenuClass); OnClick (fun _ -> ToggleBurgerMenu |> dispatch) ] [
                span [] []
                span [] []
                span [] []
            ]
        ]
        Navbar.menu [ Navbar.Menu.Option.Props [ Id "navMenu"; Class ("navbar-menu " + burgerMenuClass)] ] [
            Navbar.End.div [] [
                item Router.MindfulYoga "Mindful Yoga"
                item Router.AboutMe "O mně"
                item Router.Retreat "Podzimní retreat"
                item Router.SriLanka2020 "Srí Lanka 2020"
                item Router.Lessons "Lekce"
                item Router.Workshops "Workshopy"
                item Router.IndividualLessons "Individuální lekce"
                item Router.CompanyLessons "Jóga pro firmy"
                item Router.Contact "Kontakt"
            ]            
        ]
    ]

let footerDiv (state:State) dispatch = 
    let sendBtn =
        let isDisabled = state.SubscribeEmail |> MindfulYoga.Shared.Validation.isValidEmail |> not
        if state.IsSubscribed then
            Button.a [ ] [ 
                i [ ClassName "fas fa-check" ] [] 
                span [ Style [ MarginLeft 5 ] ] [ str "Přihlášeno"]
            ]
        else            
            match state.IsLoading with
            | true -> 
                Button.a [ ] [ 
                    str "..."
                ]
            | false ->
                let props = if isDisabled then [ Button.Disabled isDisabled ] else [Button.OnClick (fun _ -> Subscribe |> dispatch)]
                Button.a props [ 
                    str "Odeslat"
                ]

    let loadingClass = if state.IsLoading then "is-loading" else ""

    footer [ Class "footer"] [
        Container.container [] [
            Columns.columns [] [
                Column.column [ Column.Width (Screen.All, Column.IsThreeFifths); Column.Offset(Screen.All, Column.IsOneFifth )] [
                    Columns.columns [ ] [
                        Column.column [ Column.Option.CustomClass "fill"] [
                            Content.content [] [
                                h3 [] [ str "Kontakt" ]
                                div [] [ str "Ing. Jana Provazníková" ]
                                div [] [ a [ Href "mailto:jana@mindfulyoga.cz"] [ str "jana@mindfulyoga.cz"] ]
                                hr []
                                a [ Href "https://www.facebook.com/mindfulyoga.cz"] [
                                    i [ Class "fab fa-facebook-f fa-2x"; Data ("fa-transform","shrink-3.5 down-1.6 right-1.25"); Data("fa-mask","fas fa-circle") ] []                                    
                                ]
                                a [ Href "mailto:jana@mindfulyoga.cz" ] [
                                    i [ Class "far fa-envelope fa-2x"; Data ("fa-transform","shrink-5"); Data("fa-mask","fas fa-circle") ] []                                    
                                ]
                            ]
                        ]
                        Column.column [ Column.Option.CustomClass "fill"] [
                            Content.content [] [
                                h3 [] [ str "Přihlásit k odběru newsletteru" ]
                                Field.div [ Field.IsGrouped ] [
                                    p [ Class ("control is-expanded " + loadingClass)] [
                                        Input.email [ 
                                            Input.Placeholder "Vložit email"
                                            Input.OnChange (fun e -> !!e.target?value |> EmailChanged |> dispatch)
                                        ]
                                    ]
                                    p [ Class "control" ] [
                                        sendBtn
                                    ]
                                ]
                            ]
                        ]
                    ]
                ]
            ]
        ]
    ]

let render (state : State) (dispatch : Msg -> unit) =
    let currentPage = 
        match state.Page with
        | Router.AboutMe -> AboutMe.View.view
        | Router.MindfulYoga -> MindfulYoga.View.view
        | Router.Retreat -> Retreat.View.view
        | Router.Lessons -> Lessons.View.view
        | Router.IndividualLessons -> IndividualLessons.View.view
        | Router.CompanyLessons -> CompanyLessons.View.view
        | Router.Contact -> Contact.View.view
        | Router.SriLanka2020 -> SriLanka2020.View.view
        | Router.Workshops -> Workshops.View.view
        
    let showFooter =
        match state.Page with
        | Router.Contact -> false
        | _ -> true

    div [] [
        yield menu state dispatch
        yield currentPage
        if showFooter then yield (footerDiv state dispatch)
    ]