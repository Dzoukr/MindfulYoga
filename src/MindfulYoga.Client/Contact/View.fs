module MindfulYoga.Client.Contact.View

open Fulma
open Fable.React
open Fable.React.Props
open MindfulYoga.Client
open SharedViews

let view =
    div [ Class "contact"] [
        Content.content [ Content.Option.CustomClass "has-text-centered" ] [
            img [ Src "img/logo.png" ]
            h3 [] [ str "Kontakt" ]
            div [] [ str "Ing. Jana Provazníková" ]
            div [] [ str "+420 777 835 160" ]
            div [] [ a [ Href "mailto:jana@mindfulyoga.cz" ] [ str "jana@mindfulyoga.cz" ] ]
            div [] [ str "IČO: 06680810" ]
            div [] [ str "Bankovní spojení: 1681695016/3030" ]
            hr []
            a [ Class "contact-icon"; Href "https://www.facebook.com/mindfulyoga.cz"] [
                i [ Class "fab fa-facebook-f fa-2x"; Data ("fa-transform","shrink-3.5 down-1.6 right-1.25"); Data("fa-mask","fas fa-circle") ] []                                    
            ]
            a [ Class "contact-icon"; Href "mailto:jana@mindfulyoga.cz" ] [
                i [ Class "far fa-envelope fa-2x"; Data ("fa-transform","shrink-5"); Data("fa-mask","fas fa-circle") ] []                                    
            ]
        ]
    ]