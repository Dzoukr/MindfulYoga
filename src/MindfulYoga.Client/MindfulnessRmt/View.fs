module MindfulYoga.Client.MindfulnessRmt.View

open Fulma
open Fable.React
open Fable.React.Props
open Feliz
open Feliz.Bulma
open MindfulYoga.Client
open SharedViews

let view =
    div [ Class "mindfulness-rmt"] [
        emptySection
        figure [ Class "image mobile-only"] [
            img [ Src "img/mindful_bg.jpg"]
        ]
        textSection [
            Html.h1 "Mindfulness"
            
            Html.p [
                Html.text "Mindfulness je druh duševního tréninku, při kterém rozvíjíme všímavost s pomocí jednoduchých technik."
                Html.br []
                Html.h3 "Co získám, když se budu věnovat mindfulness?"
            ]
            
            [       
                "Umění žít v přítomnosti. Plně vnímám přítomným okamžik. Většinu času našeho dne trávíme vzpomínáním nebo plánováním, mezitím nám uniká, co se děje právě teď. Život nám uniká mezi prsty."
                "Mindfulness funguje jako radar ke všemu, co se uvnitř nás děje. Začínám se lépe orientovat ve svých pocitech, emocích, myšlenkách. Učím se je vnímat s určitým odstupem a akceptovat je místo jejich popírání nebo odmítání. Teprve přijetím situace si vytvářím prostor ke změně nebo ke snadnějšímu vypořádání se stresovou situací."
                "Umím zvládnout své nepříjemné pocity, které mi brání změnit to, co mi nevyhovuje. Získávám větší svobodu ve svém životě."
                "Mindfulness funguje jako radar ke všemu, co se děje vně nás. Všímám si maličkostí a drobností, které mi dělají radost. Drobnosti jsou to, co dělá člověka opravdu šťastným.  Kolik toho v životě prostě přehlédneme?"
            ] |> inList |> List.singleton |> div []
        ]
        //emptySection
        textSectionCentered [
            h4 [] [ str "Začni dělat cokoliv, co můžeš nebo o čem sníš. Smělost má v sobě génia, sílu a kouzlo." ]
            p [] [ str "- W.H. Murray"]                            
        ]
        
    ]