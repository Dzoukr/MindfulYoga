module MindfulYoga.Client.IndividualLessons.View

open Fulma
open Fable.React
open Fable.React.Props
open Feliz
open Feliz.Bulma
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
        ]
        emptySection
        textSection [
            h3 [] [ str "Mindful Yoga Therapy"]
            p [] [
                str "Individuální lekce "
                a [ Class "mindful-link"; Href Router.MindfulYoga.Path; OnClick Router.goToUrl ] [ str "Mindful yogy®"]                        
                str " vytvořená na míru s plným zohledněním Vašich aktuálních potřeb a současného zdravotního stavu."
                br []
                br []
                str "Jógová praxe, během které obracíme pozornost ke svému vnitřnímu prostředí. Dále cílí na posílení a protažení svalů a zlepšení zdraví orgánů, kostí, oběhového i dýchacího systému."
            ]
            
            h3 [] [ str "Mindful Yin Yoga Therapy"]
            p [] [
                str "Individuální lekce Mindful yin yogy vytvořená na míru s plným zohledněním Vašich aktuálních potřeb a současného zdravotního stavu."
                br []
                br []
                str "Mindful yin yoga přináší propojení yin yogy, která vychází z tradiční čínské medicíny a mindfulness. Během cvičení podporujeme růst bdělé pozornosti k vnímání svého těla.
                    Praxe, která je především statická, zahrnuje uvolnění svalových skupin a zvyšování elasticity/pružnosti vazů, kloubů a celého těla. Během tří až pětiminutových výdrží v ásanách působíme na hluboké pojivové tkáně tj. fascie, vhodně je zatížíme a tím v nich stimulujeme cirkulaci energie čchi."
            ]
                        
            Html.p [
                prop.className "cta"
                prop.children [
                    Bulma.buttonLink [
                        button.isPrimary
                        button.isMedium
                        prop.href Router.Contact.Path
                        prop.onClick (Router.goToUrl)
                        prop.text "Mám zájem o individuální lekci"
                    ]
                ]
            ]
        ]
    ]