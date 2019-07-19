module MindfulYoga.Client.View

open Domain
open Fulma
open Fable.React
open Fable.React.Props

let menu (currentPage:Router.Page) =
    
    let item (p:Router.Page) title =
        let isActive = p = currentPage
        Navbar.Item.a [ Navbar.Item.Option.IsActive isActive; Navbar.Item.Option.Props [ Href p.Path; OnClick Router.goToUrl ] ] [ str title]
    
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
                item Router.AboutMe "O mně"
                item Router.MindfulYoga "Mindful Yoga"
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
                        Column.column [] [
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
    
    div [] [
        menu state.Page
        currentPage
        footerDiv
    ]