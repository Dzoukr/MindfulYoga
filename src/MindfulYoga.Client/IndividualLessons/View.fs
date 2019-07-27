module MindfulYoga.Client.IndividualLessons.View

open Fulma
open Fable.React
open Fable.React.Props
open MindfulYoga.Client
open SharedViews


let view =
    div [ Class "individual-lessons"] [
        emptySection
        textSection [
            h1 [] [ str "Individuální lekce" ]
            p [] [
                str "Individuální lekce jógy jsou určeny pro všechny, kteří z jakéhokoliv důvodu potřebují osobní přístup nebo jim cvičení ve skupině nevyhovuje. Jsou vhodné i pro ty, kteří navštěvují skupinové lekce a chtějí se do praxe ponořit hlouběji."
                br []
                br []
                str "Lekci předchází konzultace ohledně zaměření lekce, na jejímž základě připravím koncept cvičení na míru. Při osobním setkání společně doladíme detaily a zpětně (na vyžádání) Vám zašlu plán včetně instrukcí ohledně cvičení na doma.
                Získáte řadu doporučení pro svoji praxi, aby cvičení bylo efektivní a přispívalo k Vašemu osobnímu rozvoji."
            ]
            h3 [] [ str "Mindful Yoga Therapy"]
            p [] [
                str "Individuální lekce "
                a [ Class "mindful-link"; Href Router.MindfulYoga.Path; OnClick Router.goToUrl ] [ str "mindful yogy®"]                        
                str " vytvořená na míru s plným zohledněním Vašich aktuálních potřeb a současného zdravotního stavu."
                br []
                br []
                str "Jógová praxe, během které obracíme pozornost ke svému vnitřnímu prostředí. Dále cílí na posílení a protažení svalů, což zlepšuje zdraví orgánů, kostí, oběhového i dýchacího systému."
            ]
            p [] [
                str "Cena: 1100 Kč (60-75min)"
            ]
            p [] [
                a [ Href Router.Contact.Path; OnClick Router.goToUrl ] [ 
                    str "Kontaktujte mě "
                    i [ Class "fas fa-long-arrow-alt-right" ] []
                ]  
            ]   
            h3 [] [ str "Mindful Yin Yoga Therapy"]
            p [] [
                str "Individuální lekce mindful yin yogy vytvořená na míru s plným zohledněním Vašich aktuálních potřeb a současného zdravotního stavu."
                br []
                br []
                str "Mindful yin yoga přináší propojení yin yogy, která vychází z tradiční čínské medicíny a mindfulness. Během cvičení podporujeme růst bdělé pozornosti k vnímání svého těla.
                    Praxe, která je především statická, zahrnuje uvolnění svalových skupin a zvyšování elasticity/pružnosti vazů, kloubů a celého těla. Během tří až pětiminutových výdrží v ásanách působíme na hluboké pojivové tkáně tj. fascie, vhodně je zatížíme a tím v nich stimulujeme cirkulaci energie čchi."
            ]
            p [] [
                str "Cena: 1100 Kč (60-75min)"
            ]
            p [] [
                a [ Href Router.Contact.Path; OnClick Router.goToUrl ] [ 
                    str "Kontaktujte mě "
                    i [ Class "fas fa-long-arrow-alt-right" ] []
                ]  
            ] 
        ]
    ]