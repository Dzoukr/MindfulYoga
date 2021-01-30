module MindfulYoga.Client.View

open Domain
open Fable.Core
open Fulma
open Fable.React
open Fable.React.Props
open Fable.Core.JsInterop
open Feliz
open Feliz.Bulma

// load icons
[<Fable.Core.ImportAll("@fortawesome/fontawesome-free/js/all.min.js")>]
let fontAwesome : unit = jsNative

// attach icons
fontAwesome


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
                item Router.MindfulnessRmt "Mindfulness / RMT"
                item Router.Lessons "Lekce"
                item Router.Workshops "Workshopy / RMT kurzy"
                item Router.IndividualLessons "Individuální lekce"
                item Router.CompanyLessons "Jóga pro firmy"
                item Router.AboutMe "O mně"
                item Router.Contact "Kontakt"
            ]            
        ]
        Html.div [
            prop.className "navbar-item top-icons"
            prop.children [
                Html.a [
                    prop.href "https://www.facebook.com/mindfulyoga.cz"
                    prop.children [ Html.i [ prop.className "fab fa-facebook-f fa-lg"; prop.custom("data-fa-transform", "shrink-3.5 down-1.6 right-1.25"); prop.custom("data-fa-mask", "fas fa-circle") ] ]
                ]
                Html.a [
                    prop.href "https://www.youtube.com/channel/UCqpdbmUsTNYkaEIFFnRHiMg"
                    prop.children [ Html.i [ prop.className "fab fa-youtube fa-lg"; prop.custom("data-fa-transform", "shrink-5"); prop.custom("data-fa-mask", "fas fa-circle") ] ]
                ]
            ]
        ]
    ]

let footerDiv (state:State) dispatch = 
    let sendBtn =
        let isDisabled = state.SubscribeEmail |> MindfulYoga.Shared.Validation.isValidEmail |> not
        if state.IsSubscribed then
            Bulma.button [
                button.isPrimary
                prop.children [
                    Html.i [ prop.className "fas fa-check" ]
                    Html.span [
                        prop.style [ style.marginLeft 10 ]
                        prop.text "Přihlášeno"
                    ]
                ]
            ]

        else            
            match state.IsLoading with
            | true -> Bulma.button [ button.isPrimary; prop.text "..." ]
            | false ->
                Bulma.button [
                    button.isPrimary
                    button.isMedium
                    if not isDisabled then prop.onClick (fun _ -> Subscribe |> dispatch)
                    prop.text "Odebírat novinky"
                ]

    let loadingClass = if state.IsLoading then "is-loading" else ""

    footer [ Class "footer"] [
        Container.container [] [
            Columns.columns [] [
                Column.column [ Column.Width (Screen.All, Column.Is10); Column.Offset(Screen.All, Column.Is1 )] [
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
                                a [ Href "https://www.youtube.com/channel/UCqpdbmUsTNYkaEIFFnRHiMg" ] [
                                    i [ Class "fab fa-youtube fa-2x"; Data ("fa-transform","shrink-5"); Data("fa-mask","fas fa-circle") ] []                                    
                                ]
                            ]
                        ]
                        Column.column [ Column.Option.CustomClass "fill"] [
                            Content.content [] [
                                h3 [] [ str "Chci vědět, co se děje" ]
                                Field.div [ Field.IsGrouped ] [
                                    p [ Class ("control is-expanded " + loadingClass)] [
                                        Input.email [ 
                                            Input.Size IsMedium
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
        | Router.MindfulnessRmt -> MindfulnessRmt.View.view
        | Router.Lessons -> Lessons.View.view state dispatch
        | Router.IndividualLessons -> IndividualLessons.View.view
        | Router.CompanyLessons -> CompanyLessons.View.view
        | Router.Contact -> Contact.View.view state dispatch
        | Router.Workshops -> Workshops.View.view state dispatch
        
    let showFooter =
        match state.Page with
        | Router.Contact -> false
        | _ -> true

    div [] [
        yield menu state dispatch
        yield currentPage
        if showFooter then yield (footerDiv state dispatch)
    ]