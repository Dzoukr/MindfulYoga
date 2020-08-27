module MindfulYoga.Client.EmailMe

open Feliz
open Feliz.Bulma
open MindfulYoga.Client.Domain
open MindfulYoga.Client.SharedViews

let emailForm model dispatch =
    Html.div [
        Bulma.field [
            Bulma.label "Jméno a příjmení *"
            Bulma.control [
                Bulma.textInput [
                    ValidationViews.color model.EmailFormValidationErrors (nameof(model.EmailForm.Name))
                    prop.placeholder "Vaše jméno a příjmení"
                    prop.onTextChange (fun x -> { model.EmailForm with Name = x } |> EmailFormChanged |> dispatch )
                ]
                ValidationViews.help model.EmailFormValidationErrors (nameof(model.EmailForm.Name))
            ]
        ]
        Bulma.field [
            Bulma.label "Email *"
            Bulma.control [
                Bulma.textInput [
                    ValidationViews.color model.EmailFormValidationErrors (nameof(model.EmailForm.Email))
                    prop.placeholder "Vaše emailová adresa"
                    prop.onTextChange (fun x -> { model.EmailForm with Email = x } |> EmailFormChanged |> dispatch )
                ]
                ValidationViews.help model.EmailFormValidationErrors (nameof(model.EmailForm.Email))
            ]
        ]
        Bulma.field [
            Bulma.label "Telefon"
            Bulma.control [
                Bulma.textInput [
                    prop.placeholder "+420 123 456 789"
                    prop.onTextChange (fun x -> { model.EmailForm with Phone = x } |> EmailFormChanged |> dispatch )
                ]
            ]
        ]
        Bulma.field [
            Bulma.label "Zpráva"
            Bulma.control [
                Bulma.textarea [
                    prop.placeholder "Máte nějaký dotaz?"
                    prop.onTextChange (fun x -> { model.EmailForm with Message = x } |> EmailFormChanged |> dispatch )
                ]
            ]
        ]
        Bulma.field [
            Bulma.button [
                button.isPrimary
                button.isFullwidth
                button.isMedium
                prop.text "Odeslat rezervaci"
                prop.onClick (fun _ -> SendEmailForm |> dispatch)
                if model.IsSending then yield! [ button.isLoading; prop.disabled true ]
            ]
        ]
    ]
