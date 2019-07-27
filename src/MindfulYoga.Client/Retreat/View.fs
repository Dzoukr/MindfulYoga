module MindfulYoga.Client.Retreat.View

open Fulma
open Fable.React
open Fable.React.Props
open MindfulYoga.Client
open SharedViews

let withBr txt =
    [
        str txt
        br []
    ] |> span []

let view =
    div [ Class "retreat"] [
        emptySection
        textSection [
            h1 [] [ str "Mindful Yoga Retreat v Tuněchodském Mlýně "]
            p [] [
                str "Srdečně Vás zvu ke společnému víkendu na krásném místě v Jižních Čechách. Tuněchodský Mlýn je klidné místo na samotě uprostřed krásné přírody, kde prý potkáte spíše srnku nebo lišku než člověka."
            ]
            p [] [
                str "Za ticha přírody kolem nás budeme jógovat, meditovat, odpočívat a naslouchat především sami sobě. Jemnou praxí "
                a [ Class "mindful-link"; Href Router.MindfulYoga.Path; OnClick Router.goToUrl ] [ str "mindful yogy®"]
                str " osvěžíme tělo, mysl i ducha. Užijeme si moment TADY A TEĎ."
            ]
            h3 [] [ str "Program"]
            p [] [
                withBr "Pátek:"
                withBr "18:30 Večeře"
                withBr "19:30 – 21:00 Restorativní mindful yoga"
                withBr ""
                withBr "Sobota:"
                withBr "7:30 – 8:30 Mindful slow flow yoga (mírně dynamická)"
                withBr "8:45 Snídaně"
                withBr "10:00 – 12:00 Úvod do meditace (meditační techniky, doporučení pro domácí praxi, všímavý rozhovor)"
                withBr "12:15 Oběd"
                str "Odpoledne výlet ("
                a [ Href "http://tunechodsky-mlyn.cz/tipy-na-vylet/" ] [ str "http://tunechodsky-mlyn.cz/tipy-na-vylet/" ]
                str "), možno po vlastní ose nebo společně"
                withBr ""
                withBr "18:00 Večeře"
                withBr "19:30 – 21:00 Mindful yoga pro zdravá záda"
                withBr ""
                withBr "Neděle"
                withBr "7:30 – 8:30 Mindful slow flow yoga (mírně dynamická)"
                withBr "10:00 – 12:00 Všímavá procházka (meditace v chůzi, hry na rozvíjení všímavosti)"
                withBr "12:15 Oběd"
                withBr "Ukončení programu a odjezd"
                withBr ""
                str "Změna programu vyhrazena. Účast na všech aktivitách dobrovolná."
            ]
            h3 [] [ str "Ubytování:" ]
            p [] [
                str "Jednoduše zařízené dvojlůžkové a třílůžkové pokoje. Některé s vlastním sociálním zařízením, některé se sociálním zařízením sdíleným."
            ]
            h3 [] [ str "Cena:" ]
            p [] [
                withBr "Nevratná záloha 1400 Kč za program a organizaci (v případě potřeby lze místo převést na jinou osobu stejného pohlaví)."
                withBr "Cena za ubytování a plnou vegetariánskou penzi na dvě noci 1300 Kč, platba v hotovosti při příjezdu na Tuněchodský Mlýn."
                withBr "Doprava po vlastní ose (případně se lze domluvit s ostatními ve skupině na spolujízdě)."
                withBr ""
                withBr "Po přihlášení na akci nutno do 14 dnů uhradit nevratnou zálohu 1400 Kč, jinak rezervace zaniká."
                withBr ""
                withBr "Kapacita: 10 – 15 osob"
            ]
            p [] [
                a [ Href Router.Contact.Path; OnClick Router.goToUrl ] [
                    str "V případě jakýchkoliv dotazů se neváhejte na mě obrátit "
                    i [ Class "fas fa-long-arrow-alt-right"] []
                ]    
            ]
        ]
        section [ Class "display-grid"] [
            img [ Src "https://res.cloudinary.com/mindfulyoga/image/upload/c_scale,w_2050/v1556132002/newsletters/mlyn2.jpg" ]
        ]
    ]