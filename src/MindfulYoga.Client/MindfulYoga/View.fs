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
            
            Html.p [
                prop.className "what-is"
                prop.text "Mindful yoga je praxe jógy propojující „mindfulness“ – schopnost vnímat a uvědomovat si události v přítomném okamžiku a tradiční hatha yogu – jóga stará již tisíce let."
            ]
            
            Html.p "Mindful yoga (všímavá jóga) je praxe jógy s důrazem na rozvíjení schopnosti vnímat a uvědomovat si události v přítomném okamžiku tedy během jógové praxe." 
            Html.p "Jedná se o události vnější (okolní prostředí) a vnitřní (pocity, emoce, myšlenky a procesy související s tělem – pohyb, dech)."  
            Html.p "Vytváříme prostor, který nám umožňuje snáze uslyšet signály těla a objevit, co opravdu potřebujeme, ať už na jógové podložce nebo mimo ní."
            Html.p "Zaměření pozornosti na to, co se v daném okamžiku děje a jak na probíhající procesy reagujeme, transformuje jógu do formy meditace."

            h2 [] [ str "Co získám praxí Mindful yogy?"]
            [       
                "Umění žít a praktikovat jógu v přítomnosti"
                "Nižší hladinu pociťovaného stresu"
                "Lepší orientaci ve svých pocitech, emocích, myšlenkách"
                "Vřelejší vztah k sobě – učím se přijímat a podporovat"
                "Uvolněné tělo"
                "Vyšší sebedůvěru"
                "Propojení se svým tělem"
                "Naučím se mít ráda a přijímat se"
                "Poznávám, kdo ve skutečnosti jsem a co potřebuji"
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
        textSection [
            h2 [] [ str "Jak praxe Mindful yogy probíhá?"]
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
