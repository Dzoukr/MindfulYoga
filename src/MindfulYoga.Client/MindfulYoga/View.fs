module MindfulYoga.Client.MindfulYoga.View

open Fulma
open Fable.React
open Fable.React.Props
open Feliz
open Feliz.Bulma
open MindfulYoga.Client
open SharedViews

let view =
    div [ Class "mindfulyoga"] [
        emptySection
        figure [ Class "image mobile-only"] [
            img [ Src "img/mindful_bg.jpg"]
        ]
        textSection [
            h1 [] [ str "MINDFUL YOGA "; sup [] [str "®"]]
            
            inP "Mindful yoga (všímavá jóga) je praxe jógy s důrazem na prosté uvědomování si toho, co se se mnou v přítomném okamžiku děje." 
            inP "Přijímáme pocity, emoce, myšlenky takové, jaké jsou, bez potřeby skutečnost jakkoliv měnit." 
            inP "Pozorně vnímáme každý pohyb, všímáme si pocitů, emocí, myšlenek, dechu... všeho co je dominantní. Vytváříme prostor, který nám umožňuje snáze uslyšet signály těla a objevit, co opravdu potřebujeme, ať už na podložce nebo mimo ní." 
            inP "Zaměření pozornosti na to, co se v daném okamžiku děje a jak na probíhající procesy reagujeme, transformuje jógu do formy meditace."
            inP "Vychází z praxe tradiční hatha jógy a meditace mindfulness."
            
            h2 [] [ str "Co získám praxí mindful yogy?"]
            [       
                "Sníží se mi pociťovaný stres"
                "Moje tělo se uvolní"
                "Vřelejší vztah k sobě – učím se přijímat a podporovat" 
                "Zvýší se mi sebedůvěra"
                "Učím se mít ráda a přijímat se" 
                "Propojení se svým tělem"
                "Poznávám, kdo ve skutečnosti jsem a co chci"
            ] |> inList |> List.singleton |> div []
            
            
            Html.div [
                prop.className "join"
                prop.children [
                    Html.h3 "Přidej se do skupiny podobně smýšlejících jogínek ❤️"
                ]
            ]

          
            Html.p [
                prop.className "cta"
                prop.children [
                    Bulma.buttonLink [
                        button.isPrimary
                        button.isMedium
                        prop.target "_blank"
                        prop.href "https://www.facebook.com/groups/mindfulyoga.cz"
                        prop.text "Přidat se ke skupině"
                    ]
                ]
            ]
            
        ]
        
        emptySection
        textSectionCentered [
            h4 [] [ str "\" Vše se odehrává v přítomném okamžiku, jen v něm lze věci měnit. \"" ]
        ]
        
        emptySection
        textSection [
            h2 [] [ str "Jak praxe mindful yogy funguje?"]
            [       
                "Studenti jsou neustále nabádáni k obracení pozornosti k tomu, co prožívají v přítomném okamžiku."
                "Pozorností v těle zjišťujeme, kde se v těle stres projevuje, samotné uvědomování si, pomáhá napětí odstranit."
                "Všímáme si pocitů, emocí, myšlenek, smyslových vjemů, aniž bychom na ně reagovali, pouze z pozice pozorovatele."
                "Znovu se napojíme na naše tělo a vytvoříme si prostor pro vnímání jeho signálů. Často jsme od svého těla odpojeni a žijeme jen „v hlavě“. Učíme se naslouchat našemu tělu, kde tělo říká, že se můžeme do pozice ponořit hlouběji a kde naopak máme zastavit. Při udržení této pozornosti se nedostáváme do bodu, ve kterém ucítíme bolest – každý vědomě přebírá zodpovědnost za čtení signálů vlastního těla."
                "Vnímáme, kde nás omezuje naše mysl. Prozkoumáváme svoje hranice."
                "Postupně odhalujeme a uvědomujeme si myšlenkové vzorce, tím máme možnost si uvědomit, které nám už neslouží a přeměnit je."
                "Vnímáme, jaký vliv má náš duševní a emocionální postoj na náš fyzický postoj. Změnou fyzického postoje v držení těla, dochází i k proměně postojů a pocitů."
                "Přenášíme klid a všímavost z jógamatky i do běžného života."
                "Více naživo a na vlastní kůži ... těším se na vás na lekcích!"
            ] |> inList |> List.singleton |> div []
        ]
    ]
