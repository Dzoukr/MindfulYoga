module MindfulYoga.Client.Retreat.View

open Fulma
open Fable.React
open Fable.React.Props
open MindfulYoga.Client
open SharedViews
open Feliz
open Feliz.Bulma
open MindfulYoga.Client.Domain

let withBr txt =
    [
        str txt
        br []
    ] |> span []

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
                prop.text "Odeslat rezervaci"
                prop.onClick (fun _ -> SendEmailForm |> dispatch)
                if model.IsSending then yield! [ button.isLoading; prop.disabled true ]
            ]
        ]
    ]

let view state dispatch =
    div [ Class "retreat"] [
        emptySection
        
        textSection [
            h1 [] [ str "MINDFUL DETOX YOGA RETREAT BOŘETÍNSKÝ STATEK "]
            h3 [] [ str "Víkend 17. - 19. 4. 2020" ]
            Html.p "Srdečně Vás zvu ke společnému víkendu na Bořetínském statku. Statek se nachází v malé vesničce, blízko Jindřichova Hradce, na bývalé poutní cestě ke kapli sv. Anny."
            Html.p "Bořetínský statek byl postaven v 18. století a nedávno byl citlivě zrekonstruován pod taktovkou paní architektky Moniky Krby. Celé stavení je propojené s prostorným dvorem a vesnickou zahradou."
            Html.p [
                Html.text "Za ticha přírody kolem nás budeme jógovat, meditovat, odpočívat a naslouchat především sami sobě. Jemnou praxí "
                Html.a [ prop.className "mindful-link"; prop.href Router.MindfulYoga.Path; prop.onClick Router.goToUrl; prop.text "mindful yogy®" ]
                Html.text " osvěžíme tělo, mysl i ducha. Užijeme si moment TADY A TEĎ."
            ]
            
            
            h3 [] [ str "Program:"]
            p [] [
                withBr "Pátek:"
                withBr "18:30 Večeře"
                withBr "19:30 – 21:00 Restorativní mindful yoga (meridián jater)"
                withBr ""
                withBr "Sobota:"
                withBr "7:30 – 8:30 Mindful slow flow yoga (mírně dynamická, detoxikační praxe)"
                withBr "8:45 Snídaně"
                withBr "10:00 – 12:00 Úvod do meditace (meditační techniky, doporučení pro domácí praxi, všímavý rozhovor)"
                withBr "12:15 Všímavý oběd (instrukce k mindful eating)"
                str "Odpoledne výlet ("
                a [ Href "https://boretinskystatek.cz/okoli.html" ] [ str "https://boretinskystatek.cz/okoli.html" ]
                str "), možno po vlastní ose nebo společně"
                withBr ""
                withBr "18:00 Večeře"
                withBr "19:30 – 21:00 Mindful yoga (jemná večerní praxe)"
                withBr ""
                withBr "Neděle"
                withBr "7:30 – 8:30 Mindful slow flow yoga (mírně dynamická, detoxikační praxe)"
                withBr "10:00 – 12:00 Všímavá procházka (meditace v chůzi, hry na rozvíjení všímavosti)"
                withBr "12:15 Oběd"
                withBr "Ukončení programu a odjezd"
                withBr ""
                str "Změna programu vyhrazena. Účast na všech aktivitách dobrovolná."
            ]
            h3 [] [ str "Ubytování:" ]
            p [] [
                str "Krásně a útulně zařízené dvojlůžkové, třílůžkové i vícelůžkové pokoje s vlastním sociálním zařízením."
            ]
            h3 [] [ str "Cena:" ]
            p [] [
                withBr "Nevratná záloha 1500 Kč za program a organizaci (v případě potřeby lze místo převést na jinou osobu stejného pohlaví)."
                withBr "Cena za ubytování, pronájem sálu, plnou vegetariánskou penzi na dvě noci 1905 Kč, platba v hotovosti při příjezdu na Bořetínský statek (plus 15,- osoba/noc vzdušné)."
                withBr "Doprava po vlastní ose (případně se lze domluvit s ostatními ve skupině na spolujízdě)."
                withBr ""
                withBr "Po přihlášení na akci nutno do 14 dnů uhradit nevratnou zálohu 1500 Kč, jinak rezervace zaniká."
                withBr ""
                withBr "Omezená kapacita: max. 16 osob"
            ]
            Bulma.section [
                Bulma.columns [
                    Bulma.column [ column.is2 ]
                    Bulma.column [
                        Html.h1 [ prop.text "Rezervujte si své místo na retreatu"; prop.style [ style.marginBottom (length.rem 2) ] ]
                        emailForm state dispatch
                    ]
                    Bulma.column [ column.is2 ]
                ]
            ]
        ]
        Html.section [
            prop.className "display-grid"
            prop.children [
                Html.img [ prop.src "img/retreat_banner.jpg" ]
            ]
        ]
    ]