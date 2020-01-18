module MindfulYoga.Client.Contact.View

open Fulma
open Fable.React
open Fable.React.Props
open Feliz
open Feliz
open Feliz.Bulma
open MindfulYoga.Client
open SharedViews
open MindfulYoga.Client.Domain

let emailForm model dispatch =
    Html.div [
        Bulma.field [
            Bulma.label "Vaše jméno a příjmení *"
            Bulma.control [
                Bulma.textInput [
                    ValidationViews.color model.EmailFormValidationErrors (nameof(model.EmailForm.Name))
                    prop.onTextChange (fun x -> { model.EmailForm with Name = x } |> EmailFormChanged |> dispatch )
                ]
                ValidationViews.help model.EmailFormValidationErrors (nameof(model.EmailForm.Name))
            ]
        ]
        Bulma.field [
            Bulma.label "Váš email *"
            Bulma.control [
                Bulma.textInput [
                    ValidationViews.color model.EmailFormValidationErrors (nameof(model.EmailForm.Email))
                    prop.onTextChange (fun x -> { model.EmailForm with Email = x } |> EmailFormChanged |> dispatch )
                ]
                ValidationViews.help model.EmailFormValidationErrors (nameof(model.EmailForm.Email))
            ]
        ]
        Bulma.field [
            Bulma.label "Zpráva"
            Bulma.control [
                Bulma.textarea [
                    prop.onTextChange (fun x -> { model.EmailForm with Message = x } |> EmailFormChanged |> dispatch )
                ]
            ]
        ]
        Bulma.field [
            Bulma.button [
                button.isPrimary
                button.isFullwidth
                button.isMedium
                prop.text "Odeslat zprávu"
                prop.onClick (fun _ -> SendEmailForm |> dispatch)
                if model.IsSending then yield! [ button.isLoading; prop.disabled true ]
            ]
        ]
    ]

let view model dispatch =
    div [ Class "contact"] [
        textSection [
            Bulma.title "Máte jakýkoliv dotaz? Neváhejte mě kontaktovat."
            Html.br []
            emailForm model dispatch
        ]
        
        Content.content [ Content.Option.CustomClass "has-text-centered summary" ] [
            div [] [ str "Ing. Jana Provazníková" ]
            div [] [ str "+420 777 835 160" ]
            div [] [ a [ Href "mailto:jana@mindfulyoga.cz" ] [ str "jana@mindfulyoga.cz" ] ]
            div [] [ str "IČO: 06680810" ]
            div [] [ str "Bankovní spojení: 1681695016/3030" ]
            a [ Class "contact-icon"; Href "https://www.facebook.com/mindfulyoga.cz"] [
                i [ Class "fab fa-facebook-f fa-2x"; Data ("fa-transform","shrink-3.5 down-1.6 right-1.25"); Data("fa-mask","fas fa-circle") ] []                                    
            ]
            a [ Class "contact-icon"; Href "mailto:jana@mindfulyoga.cz" ] [
                i [ Class "far fa-envelope fa-2x"; Data ("fa-transform","shrink-5"); Data("fa-mask","fas fa-circle") ] []                                    
            ]
        ]
        
    ]