module MindfulYoga.Client.View

open Domain
open Fulma
open Fable.React
open Fable.React.Props

let menu (currentPage:Router.Page) =
    
    let item (p:Router.Page) title =
        let isActive = p = currentPage
        Navbar.Item.a [ Navbar.Item.Option.IsActive isActive; Navbar.Item.Option.Props [ Href p.Path; OnClick Router.goToUrl ] ] [ str title]
    let itemBold (p:Router.Page) title =
        let isActive = p = currentPage
        Navbar.Item.a [ Navbar.Item.Option.IsActive isActive; Navbar.Item.Option.Props [ Href p.Path; OnClick Router.goToUrl ] ] [ strong [] [ str title ] ]

    Navbar.navbar [ Navbar.Option.IsTransparent ] [
        Navbar.Brand.div [] [
            Navbar.Item.a [ Navbar.Item.Option.Props [ Href Router.AboutMe.Path; OnClick Router.goToUrl ] ] [
                img [ Src "img/logo.png" ]
            ]
            a [ Class "navbar-burger"; Data ("target","navMenu") ] [
                span [] []
                span [] []
                span [] []
            ]
        ]
        Navbar.menu [ Navbar.Menu.Option.Props [ Id "navMenu"] ] [
            Navbar.End.div [] [
                itemBold Router.MindfulYoga "Mindful Yoga"
                item Router.AboutMe "O mně"
                item Router.Retreat "Retreat"
                item Router.Lessons "Lekce"
                item Router.IndividualLessons "Individuální lekce"
                item Router.CompanyLessons "Jóga pro firmy"
                item Router.Workshops "Workshopy"
                item Router.Contact "Kontakt"
            ]            
        ]
    ]

let footerDiv = 
    footer [ Class "footer"] [
        Container.container [] [
            Columns.columns [] [
                Column.column [ Column.Width (Screen.All, Column.IsThreeFifths); Column.Offset(Screen.All, Column.IsOneFifth )] [
                    Columns.columns [ ] [
                        Column.column [ Column.Option.CustomClass "fill"] [
                            img [ Src "img/logo.png" ]                            
                        ]
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
    
    let showFooter =
        match state.Page with
        | Router.Contact -> false
        | _ -> true

    div [] [
        yield menu state.Page
        yield currentPage
        if showFooter then yield footerDiv
    ]