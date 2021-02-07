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
            
            inP "Ve workshopu podpoříme především proudění energie v meridiánu tlustého střeva, který společně s plícemi, sdílí energetické charakteristiky spočívající v neustále se opakujících cyklech čerpání výživy a zbavování se odpadu."
            inP "Právě střeva jsou klíčovým orgánem imunity."
            inP "Čchi tlustého střeva je spojena s odvahou a důstojností, se schopností prožívat vzácnost okamžiku. Pokud je oslabena na fyzické úrovni se projeví nachlazeními, rýmou, alergiemi, kašlem, ale i různými ekzémy na kůži."
            inP "Zaměříme se na hrudník a jeho otevírání, na vytváření prostoru pro naše plíce pro plnější nádech a výdech."
            inP "Součástí workshopu je technika Relation Mindfulness, kde v rámci Všímavého rozhovoru budeme sami v sobě nacházet odpovědi na to, co opravdu potřebujeme"
            
            h1 [] [ str "Vitalita: Mindful Yin Yoga" ]
            
            inP "Ve workshopu podpoříme především proudění energie v meridiánu žlučníku, který se společně s játry stará o detoxikaci našeho těla. Taoisté pokládají zdravou čchi žlučníku zodpovědnou za vytváření pocitu pohody a dobré vnitřní atmosféry."
            inP "Žlučník se vztahuje k naší schopnosti jít svou životní cestou a dojde-li ke zmaření našich plánů nebo k překážkám, energie čchi žlučníku nám pomáhá znovu najít rovnováhu."
            inP "Zvýšíme ohebnost / pružnost naší páteře a uvolníme celou oblast zad, aby se nám snáze předklánělo, zaklánělo, uklánělo a přetáčelo."
            inP "Součástí workshopu je technika Relation Mindfulness, kde v rámci Všímavého rozhovoru budeme sami v sobě nacházet odpovědi na to, co opravdu potřebujeme."
            
            h1 [] [ str "MINDFUL YIN YOGA" ]
            
            inP "Všímavost v józe je postoj, kterým přijímáme a v němž pouštíme všechny snahy o manipulaci přítomným okamžikem a rozvíjíme schopnost pozorování bez tendence jakkoliv do něj zasahovat. Otevíráme se sami sobě, otevíráme se světu."
            inP "V rámci setkání se blíže seznámíte s mindfulness a jejím využitím nejen v jógové praxi, ale i během celého dne. Užijeme si relaxaci, dotkneme se meditace a rozebereme, jak se účinně během dne zastavovat."
            inP "Harmonizujeme tok energie v meridiánu plic, jehož činnost v měsíci listopadu vrcholí. Podpoříme naše plíce jakožto životodárný orgán pro celé tělo. Vytvoříme prostor pro odpověď na otázku „Co potřebuji pro to, aby se mi v životě lépe dýchalo?“."
            inP "Workshop je vhodný pro všechny bez ohledu na pokročilost praxe. Zvláště pro ty, kteří by rádi prohloubili svoji praxi a snadněji psychicky zvládali každodenní situace."
            
            Html.div [
                prop.className "workshop-info"
                prop.text "V tuto chvíli není další termín workshopů naplánován, v případě Vašeho zájmu o workshop, mě prosím neváhejte kontaktovat a já Vás budu informovat hned, jakmile se bude blížit jeho termín otevření." 
            ]
            
            Html.p [
                prop.className "cta"
                prop.children [
                    Bulma.buttonLink [
                        button.isPrimary
                        button.isMedium
                        prop.target "_blank"
                        prop.href "/kontakt"
                        prop.text "Informuj mě"
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
            
            Html.h3 "Co získám, když se budu věnovat relation mindfulness?"
            [
                "Naučím se pracovat se stresem a vlastními emocemi, a to především v momentech, kdy komunikuji nebo spolupracuji s druhými lidmi."
                "Prohloubení a zlepšení vztahů. Stávám se laskavější, empatičtější a pozornější k lidem v mém okolí." 
                "Zlepšení orientace sám v sobě. Poznávám a uvědomuji si svoje reakce při komunikaci. Učím se pochopit a změnit ty, které mi nevyhovují." 
                "Zvládám konfliktní situace s větší lehkostí, naučím se nenásilnou cestou říci o to, co skutečně potřebuji. Zlepšuji svoje komunikační dovednosti." 
                "Vím, co chci a co ne, snadněji nastavuji hranice vůči ostatním." 
            ] |> inList |> List.singleton |> div []            
            
            Html.div [
                prop.className "workshop-info"
                prop.text "V tuto chvíli není další termín kurzu naplánován, v případě Vašeho zájmu o kurz, mě prosím neváhejte kontaktovat a já Vás budu informovat hned, jakmile se bude blížit jeho termín otevření."
            ]
            
            Html.p [
                prop.className "cta"
                prop.children [
                    Bulma.buttonLink [
                        button.isPrimary
                        button.isMedium
                        prop.target "_blank"
                        prop.href "/kontakt"
                        prop.text "Informuj mě"
                    ]
                ]
            ]
            
            Html.h3 "Spolupracuji:"            
            Html.p [
                text.hasTextCentered
                prop.children [
                    Html.img [
                        prop.src "img/mindfulnessclub.png"
                    ]
                ]
            ]
        ]
    ]