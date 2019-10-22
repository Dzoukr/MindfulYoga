module MindfulYoga.Client.Workshops.View

open Fable.React
open Fable.React.Props
open MindfulYoga.Client
open SharedViews

let view =
    div [ Class "workshops"] [
        
        emptySection
        textSection [
            h1 [] [ str "Jóga pro klidnou mysl" ]
            inP "Celodenní seminář propojující jógu a meditaci ve všímavý pohyb, učící nás vnímat své tělo, všímat si pocitů, emocí, myšlenek, které se během cvičení objevují. Tím pak prohlubovat naše zapojení jak do vnějšího, tak do vnitřního světa."
            inP "V teoretické části se seznámíme s mindfulness a objasníme si, co je všímavá (mindful) jóga a jak všímavost integrovat do pohybu. Projdeme několik meditací a ve dvou blocích cvičení se naučíme kotvit v přítomnosti skrze prohlubování pozornosti a uvědomování si našeho těla."
            inP "Workshop proběhne ve třech termínech:"
            inList [ "10. listopadu 2019"; "19. ledna 2020"; "5. dubna 2020" ]
            inP "v čase od 9:30 - 16:00."
            inP "Dům jógy, metro Anděl, Ostrovského 11/16, Praha 5"
            inP "Cena: 1450,- Kč, rezervační záloha: 650,- Kč"
            inPraw "Rezervace: <a href='https://dum-jogy.cz/kurzy-a-pobyty/kurzy-a-workshopy/joga-pro-klidnou-mysl.html'>https://dum-jogy.cz/kurzy-a-pobyty/kurzy-a-workshopy/joga-pro-klidnou-mysl.html</a>"

        ]
        emptySection
        textSection [
            h1 [] [ str "YIN YOGA & MINDFULNESS vol. 1-2" ]
                        
            inP "V období podzimu nás sama příroda nabádá k uchýlení se do sebe a k odpočinku.  I mě to vede tímto směrem. Jinová praxe se hlásí mnohem více o slovo, než tomu bylo v předchozích teplých měsících."
            inP "Ráda bych se o požitek, uvolnění a relaxaci s Vámi podělila, a tak si Vás dovoluji pozvat na dva workshopy YIN YOGA & MINDFULNESS."
            inP "Yin Yoga, původně známá jako taoistická jóga, nás vede k nacházení ticha a klidu uvnitř nás. Vytváří prostor k pozornému naslouchání vlastnímu tělu, opětovnému napojení se něj a směřuje nás tak plnému prožívání sama sebe."
            inP "Jejím cílem je rozpouštění blokád na energetických drahách (meridiánech), aby mohla energie volně proudit a naše tělo se udrželo ve zdraví. Je pro ni charakteristické dlouhé spočinutí v pozicích (3 - 5minut), kterým působíme na hluboké pojivové tkáně tj. fascie, protahujeme je a znovuobnovujeme elasticitu těla."
            inP "Propojením jin jógy a meditace všímavosti (mindfulness) vytváříme silné možnosti transformace a holistického léčení na všech vrstvách bytí - těle, mysli a srdci. Meditace uklidňuje mysl, snižuje stres / úzkost a podporuje naši schopnost být v životě více přítomný. Studie ukazují, že meditace zlepšuje zdraví mozku a imunitního systému, snižuje krevní tlak, zlepšuje kvalitu spánku a dává nám více energie k užívání si radostí života."
            inP "Ve dvou workshopech se zaměříme na usměrnění toku energie v meridiánu tlustého střeva a plic, jejichž činnost v měsících listopadu a prosinci vrcholí. Uvolníme hrudník, zvýšíme mobilitu ramen a protáhneme linie našich paží. Protahovat budeme ale i naše kyčle, přední a zadní stranu těla."
            inP "Přijďte se zastavit a načerpat energii v tomto předvánočním čase."
            inP "Workshopy proběhnou:"
            inList ["24. 11. 2019"; "8. 12. 2019"]
            inP "v časech 18:30 – 20:30."
            inP "Místo: GaPa, Centrum volného času, U pošty 822, Kostelec nad Labem"
            
            inP "Cena: 350 Kč za jeden workshop, 600 Kč za oba workshopy. Platba v hotovosti nebo převodem na účet 1681695016/3030 (do poznámky uveďte celé své jméno)"
            inP "Kapacita: 10 osob"
            inPraw "Přihlášení: <a href='mailto:jana@mindfulyoga.cz'>jana@mindfulyoga.cz</a>, 777 835 160"
            inPraw "<i>Storno podmínky: Po přihlášení na akci nutno do 5 dnů uhradit v plné výši buď hotově nebo převodem, jinak rezervace zaniká. Při stornu do 7 dnů před konáním akce 100% částky zpět. Později je platba nevratná, místo možno převést na jinou osobu.</i>"
        ]
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
            inPraw "Rezervace: <a href='https://mindfulnessclub.zarezervujse.cz/cs/#/term/96314/2020-01-08;viewMode=day'>https://mindfulnessclub.zarezervujse.cz/cs/#/term/96314/2020-01-08;viewMode=day</a>"
            inPraw "Více info: <a href='https://www.facebook.com/events/1326301337519795/'>https://www.facebook.com/events/1326301337519795/</a>"
        ]
    ]