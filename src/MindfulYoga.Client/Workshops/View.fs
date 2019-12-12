module MindfulYoga.Client.Workshops.View

open Fable.React
open Fable.React.Props
open MindfulYoga.Client
open SharedViews

let view =
    div [ Class "workshops"] [
        
        emptySection
        textSection [
            h1 [] [ str "Osmitýdenní kurz mindfulness RMT" ]
            inP "Chcete se naučit lépe zvládat stres, získat větší nadhled v mezilidských vztazích, nebo zlepšit své komunikační dovednosti?"
            inP "Zvu Vás k účasti na 8-týdenním programu Relational Mindfulness Training (RMT), který se zaměřuje na rozvoj mindfulness (všímavosti) v komunikaci a interakci s druhými lidmi."
            inP "Program je navržen tak, aby Vám pomohl stát se sebevědomějším, stabilnějším a pozornějším člověkem ve společnosti. Vědecký výzkum prokázal, že účast v RMT pomáhá výrazně snížit stres, zlepšit psychickou odolnost a také rozvinout pozornost, empatii a komunikačních dovednosti."
            p [] [
                str "Týdenní setkání: Vždy ve středu od 8. 1. do 26. 02. 2020, 18:30 - 20:30"
                br []
                str "Víkendové setkání: Sobota 15. 2. 2020 9:00 – 16:00"
                br []
            ] 
            inP "Cena: 2 900 Kč (studenti, důchodci, matky samoživitelky 1 900 Kč)"
            inP "Skupina je omezena na 12 lidí."
            inPraw "Rezervace: <strong><a href='https://mindfulnessclub.zarezervujse.cz/cs/#/term/96314/2020-01-08;viewMode=day'>https://mindfulnessclub.zarezervujse.cz/cs/#/term/96314/2020-01-08;viewMode=day</a></strong>"
            inPraw "Více info: <a href='https://www.facebook.com/events/1326301337519795/'>https://www.facebook.com/events/1326301337519795/</a>"
        ]
        
        emptySection
        textSection [
            h1 [] [ str "Jóga pro klidnou mysl" ]
            inP "Celodenní seminář propojující jógu a meditaci ve všímavý pohyb, učící nás vnímat své tělo, všímat si pocitů, emocí, myšlenek, které se během cvičení objevují. Tím pak prohlubovat naše zapojení jak do vnějšího, tak do vnitřního světa."
            inP "V teoretické části se seznámíme s mindfulness a objasníme si, co je všímavá (mindful) jóga a jak všímavost integrovat do pohybu. Projdeme několik meditací a ve dvou blocích cvičení se naučíme kotvit v přítomnosti skrze prohlubování pozornosti a uvědomování si našeho těla."
            inP "Workshop proběhne ve třech termínech:"
            inList [ "19. ledna 2020"; "5. dubna 2020" ]
            inP "v čase od 9:30 - 16:00."
            inP "Dům jógy, metro Anděl, Ostrovského 11/16, Praha 5"
            inP "Cena: 1450,- Kč, rezervační záloha: 650,- Kč"
            inPraw "Rezervace: <strong><a href='https://dum-jogy.cz/kurzy-a-pobyty/kurzy-a-workshopy/joga-pro-klidnou-mysl.html'>https://dum-jogy.cz/kurzy-a-pobyty/kurzy-a-workshopy/joga-pro-klidnou-mysl.html</a></strong>"

        ]
       
    ]