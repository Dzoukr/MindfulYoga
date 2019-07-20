module MindfulYoga.Client.CompanyLessons.View

open Fulma
open Fable.React
open Fable.React.Props
open MindfulYoga.Client
open SharedViews


let view =
    div [ Class "company-lessons"] [
        emptySection
        textSection [
            h1 [] [ str "Jóga pro firmy" ]
            p [] [
                str "Bolesti zad jsou v současnosti jedním z nejčastějších civilizačních onemocnění.
                    Zhruba polovinu všech kancelářských pracovníků trápí bolestivá záda.
                    Dlouhodobé setrvání v jedné poloze vede k únavě svalstva, které má vliv na
                    správné držení páteře. Nesprávné postavení páteře se krátkodobě projevuje
                    bolestí. V dlouhodobém horizontu může přerůst do chronického stavu a vést k
                    degenerativním změnám páteře."
            ]
            p [] [
                str "Pravidelné preventivní cvičení s nácvikem správného držení těla výrazně
                    omezuje negativní dopady dlouhodobého sezení."
            ]
            p [] [
                str "Mezi hlavní benefity patří:"

            ]
            [       
                "Prevence bolestí zad způsobených sedavým zaměstnáním"
                "Úleva od bolesti zad a krční páteře"
                "Tzv. pročistí hlavu → růst pracovní výkonnosti"
                "Pracuje s chronickým stresem"
                "Posiluje koncentraci"
                "Stmeluje kolektiv a vytváří pozitivní pracovní prostředí"
            ] |> inList |> List.singleton |> div []
            p [] [
                str "Cvičení jógy během pracovního dne probíhá nejčastěji ráno před začátkem pracovní doby nebo během polední pauzy."
            ]
            p [] [
                str "Délka lekce 60 nebo 45 minut, dle Vašich časových možností."
            ]
            p [] [
                str "Lekce probíhá v zasedací místnosti, nebo kdekoliv ve firmě, kde lze vytvořit volný prostor. Případně lze domluvit pronájem sálu v blízkosti firmy. Pomůcky (podložky, pásky, deky…) dovezu až na místo."
            ]
            p [] [
                str "Cena dle počtu účastníků a vzdálenosti."
            ]
            p [] [
                a [ Href Router.Contact.Path; OnClick Router.goToUrl ] [ 
                    str "Pro nabídku mne neváhejte kontaktovat "
                    i [ Class "fas fa-long-arrow-alt-right" ] []
                ]  
            ]
        ]
        emptySection
        textSection [
            h1 [] [ str "Reference"]
            div [ Id "quote-begin" ] [ str "“"]
            div [ Id "quote-content"; Class "column" ] [
                str "Jana u nás ve firmě vedla jednorázovou lekci jógy na podzim 2017. Tato lekce
                    měla velký úspěch, takže jsme na rok 2018 domluvili pravidelné lekce 1x týdně
                    před prací. Jsme velmi spokojeni, Jana je trpělivá, stará se, abychom cvičili
                    dobře, opravuje nás a vede. Naše záda jsou teď zase o něco zdravější.
                    Organizace i komunikace s Janou je naprosto perfektní."
                br []
                br []
                str "Lenka Rašková, Office Manager, Lundegaard"
            ]
            div [ Id "quote-end"] [ str "”"]
        ]
    ]