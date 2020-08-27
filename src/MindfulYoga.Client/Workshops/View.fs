module MindfulYoga.Client.Workshops.View

open Fable.React
open Fable.React.Props
open MindfulYoga.Client
open Feliz
open Feliz.Bulma
open SharedViews
open MindfulYoga.Client.EmailMe

let view state dispatch =
    div [ Class "workshops"] [
        emptySection
        textSection [
            h1 [] [ str "Imunita: Mindful Yin Yoga" ]
            h3 [] [ str "27.9. 2020 18:30 - 20:30 (Rodinné centrum GaPa, Kostelec nad Labem)" ]
            
            inP "Ve workshopu podpoříme především proudění energie v meridiánu tlustého střeva, který společně s plícemi, sdílí energetické charakteristiky spočívající v neustále se opakujících cyklech čerpání výživy a zbavování se odpadu."
            inP "Právě střeva jsou klíčovým orgánem imunity."
            inP "Čchi tlustého střeva je spojena s odvahou a důstojností, se schopností prožívat vzácnost okamžiku. Pokud je oslabena na fyzické úrovni se projeví nachlazeními, rýmou, alergiemi, kašlem, ale i různými ekzémy na kůži."
            inP "Zaměříme se na hrudník a jeho otevírání, na vytváření prostoru pro naše plíce pro plnější nádech a výdech."
            inP "Součástí workshopu je technika Relation Mindfulness, kde v rámci Všímavého rozhovoru budeme sami v sobě nacházet odpovědi na to, co opravdu potřebujeme"
        ]
        
        textSection [
            h1 [] [ str "Vitalita: Mindful Yin Yoga" ]
            h3 [] [ str "25.10. 2020 18:30 – 20:30 (Rodinné centrum GaPa, Kostelec nad Labem)" ]
            
            inP "Ve workshopu podpoříme především proudění energie v meridiánu žlučníku, který se společně s játry stará o detoxikaci našeho těla. Taoisté pokládají zdravou čchi žlučníku zodpovědnou za vytváření pocitu pohody a dobré vnitřní atmosféry."
            inP "Žlučník se vztahuje k naší schopnosti jít svou životní cestou a dojde-li ke zmaření našich plánů nebo k překážkám, energie čchi žlučníku nám pomáhá znovu najít rovnováhu."
            inP "Zvýšíme ohebnost / pružnost naší páteře a uvolníme celou oblast zad, aby se nám snáze předklánělo, zaklánělo, uklánělo a přetáčelo."
            inP "Součástí workshopu je technika Relation Mindfulness, kde v rámci Všímavého rozhovoru budeme sami v sobě nacházet odpovědi na to, co opravdu potřebujeme."
        ]
        
        textSection [
            Bulma.columns [
                Bulma.column [ column.is1 ]
                Bulma.column [
                    Html.h1 [ prop.text "Rezervujte si své místo na workshopu"; prop.style [ style.marginBottom (length.rem 2) ] ]
                    emailForm state dispatch
                ]
                Bulma.column [ column.is1 ]
            ]
        ]
        
        textSection [
            inPraw "<i>Cena: 350Kč za jeden workshop, 700 Kč za oba workshopy, platba v hotovosti nebo převodem na účet 1681695016/3030 (do poznámky uveďte celé své jméno)</i>"
            inPraw "<i>Kapacita: 10 osob</i>"
            inPraw "<i>Storno podmínky: Po přihlášení na akci nutno do 5 dnů uhradit v plné výši buď hotově nebo převodem, jinak rezervace zaniká. Při stornu do 7 dnů před konáním akce 100% částky zpět. Později je platba nevratná, místo možno převést na jinou osobu.</i>"
        ]
        
        emptySection
        textSection [
            h1 [] [ str "MINDFUL YIN YOGA" ]
            h3 [] [ str "21.11. 2020 9:00 – 12:00 (Dům jógy Příbram)" ]
            
            inP "Všímavost v józe je postoj, kterým přijímáme a v němž pouštíme všechny snahy o manipulaci přítomným okamžikem a rozvíjíme schopnost pozorování bez tendence jakkoliv do něj zasahovat. Otevíráme se sami sobě, otevíráme se světu."
            inP "V rámci setkání se blíže seznámíte s mindfulness a jejím využitím nejen v jógové praxi, ale i během celého dne. Užijeme si relaxaci, dotkneme se meditace a rozebereme, jak se účinně během dne zastavovat."
            inP "Harmonizujeme tok energie v meridiánu plic, jehož činnost v měsíci listopadu vrcholí. Podpoříme naše plíce jakožto životodárný orgán pro celé tělo. Vytvoříme prostor pro odpověď na otázku „Co potřebuji pro to, aby se mi v životě lépe dýchalo?“."
            inP "Workshop je vhodný pro všechny bez ohledu na pokročilost praxe. Zvláště pro ty, kteří by rádi prohloubili svoji praxi a snadněji psychicky zvládali každodenní situace."
            Html.p [
                prop.className "cta"
                prop.children [
                    Bulma.buttonLink [
                        button.isPrimary
                        button.isMedium
                        prop.target "_blank"
                        prop.href "https://dumjogypribram.cz/novinky/workshop-mindful-jin-joga-sobota-21-listopadu-20/260/"
                        prop.text "Více info a přihlášení"
                    ]
                ]
            ]
        ]
        
        
        emptySection
        textSection [
            h1 [] [ str "Osmitýdenní kurz mindfulness RMT" ]
            inP "Chcete se naučit lépe zvládat stres, získat větší nadhled v mezilidských vztazích, nebo zlepšit své komunikační dovednosti?"
            inP "Zvu Vás k účasti na 8-týdenním programu Relational Mindfulness Training (RMT), který se zaměřuje na rozvoj mindfulness (všímavosti) v komunikaci a interakci s druhými lidmi."
            inP "Program je navržen tak, aby Vám pomohl stát se sebevědomějším, stabilnějším a pozornějším člověkem ve společnosti. Vědecký výzkum prokázal, že účast v RMT pomáhá výrazně snížit stres, zlepšit psychickou odolnost a také rozvinout pozornost, empatii a komunikačních dovednosti."
            inPraw "<i>V tuto chvíli není další termín kurzu naplánován, v případě Vašeho zájmu o kurz, mě prosím neváhejte kontaktovat a já Vás budu informovat hned, jakmile se bude blížit jeho termín otevření.</i>"
        ]
    ]