module MindfulYoga.Client.Online.View

open Fulma
open Fable.React
open Fable.React.Props
open MindfulYoga.Client
open SharedViews
open Feliz
open Feliz.Bulma
open MindfulYoga.Client.Domain

type Lesson = {
    Title : string
    Name : string
    Description : string
}

let lessonsGapa = [
    { Title = "Pondělí, 18:15 – 19:25"; Name = "Mindful yoga pro zdravá záda"; Description = "Rozvíjení všímavosti během klidně plynoucí lekce jógy. S ochotou vcítit se do svého těla, směřujeme pozornost k tomu, co prožíváme v přítomném okamžiku. Vědomě dýcháme.</br></br>Lekce s důrazem na zmírnění a prevenci bolestí zad. Protažení zkrácených svalů trupu a posílení ochablých svalů, které neposkytují dobrou oporu. Podpora správného držení těla a aktivace hlubokého stabilizačního systému páteře.</br></br>Jóga vhodná pro začátečníky, ale i pro pokročilé, kteří dávají přednost jemnější praxi. Vhodné i pro seniory a pro všechny se sníženou pohyblivostí, těhotné a po porodu."}
    { Title = "Pondělí, 19:40 – 20:50"; Name = "Mindful flow yoga"; Description = "Probouzíme v sobě radost a hravost během pozdravů slunci. Občas čelíme nějaké výzvě. Posilujeme střed těla, svaly kolem páteře, uvolňujeme kyčle.</br></br>Skrze vědomý dech udždžají zklidňujeme nervový systém, tišíme mysl a detoxikujeme tělo. Vše s plným respektem k našemu tělu a rozvíjející se všímavostí k momentu TADY A TEĎ. Lekce zakončena relaxací.</br></br>Dynamická lekce vhodná pro pokročilejší jogíny."}
    { Title = "Čtvrtek, 19:00 – 20:10"; Name = "Mindful easy flow"; Description = "Jemné plynutí na vlně dechu, během kterého vlídně rozproudíme energii v celém těle. Zůstáváme v kontaktu s tím, co se v nás děje a vytváříme podmínky pro uvolnění přebytečného napětí a stresu.</br></br>Lehce dynamická jóga se zaměřením na protažení a posílení celého těla, které zlepšuje zdraví orgánů a oběhového i dýchacího systému.</br></br>Vhodné pro začátečníky i pro pokročilejší jogíny."}
]

let lessonsDj = [
    { Title = "Středa, 7:30 – 8:30"; Name = "Hatha jóga - Mindful yoga"; Description = "Propojení tradiční hatha jógy a praxe mindfulness. Klidné plynutí s dechem, během kterého postupně probouzíme naše tělo a připravujeme se na nový den. Zůstáváme v kontaktu s tím, co se v nás děje a pomáháme tělu uvolnit přebytečné napětí a stres. Začínáme krátkou meditací a dechovými technikami, následuje jemné protažení a pomalé rozpohybování.<br/>Jóga vhodná pro všechny úrovně pokročilosti."}
]

let lessonsSection lsns =
    lsns
    |> List.map (fun x -> 
        [
            h3 [] [ str (sprintf "%s / %s" x.Title x.Name)]
            p [ DangerouslySetInnerHTML { __html = x.Description }] [ ]
        ]
    )
    |> List.collect id

let emailForm (model:State) dispatch =
    Html.div [
        Bulma.field [
            Bulma.label "Vaše jméno a příjmení *"
            Bulma.control [
                Bulma.textInput [
                    ValidationViews.color model.EmailFormValidationErrors (nameof(model.EmailForm.Name))
                    prop.onTextChange (fun x -> { model.EmailForm with Name = x } |> EmailFormChanged |> dispatch )
                ]
                ValidationViews.help model.EmailFormValidationErrors (nameof(model.EmailForm.Name))
            ]
        ]
        Bulma.field [
            Bulma.label "Váš email *"
            Bulma.control [
                Bulma.textInput [
                    ValidationViews.color model.EmailFormValidationErrors (nameof(model.EmailForm.Email))
                    prop.onTextChange (fun x -> { model.EmailForm with Email = x } |> EmailFormChanged |> dispatch )
                ]
                ValidationViews.help model.EmailFormValidationErrors (nameof(model.EmailForm.Email))
            ]
        ]
        Bulma.field [
            Bulma.label "Zpráva"
            Bulma.control [
                Bulma.textarea [
                    prop.onTextChange (fun x -> { model.EmailForm with Message = x } |> EmailFormChanged |> dispatch )
                ]
            ]
        ]
        Bulma.field [
            Bulma.button [
                button.isPrimary
                button.isFullwidth
                button.isMedium
                prop.text "Přihlásit se"
                prop.onClick (fun _ -> SendEmailForm |> dispatch)
                if model.IsSending then yield! [ button.isLoading; prop.disabled true ]
            ]
        ]
    ]

let view state dispatch =
    div [ Class "lessons"] [
        
        emptySection
        textSection [
            h1 [] [ str "Všímavost růže přináší: Mindful flow yoga"]
            Html.h2 "Středy 19:00 - 20:10"
            Html.p "Druhý běh pětitýdenního kurzu dynamické všímavé jógy pro všechny milovníky dynamických stylů jógy."
            Html.p "S radostí vklouzneme do hravé plynulé sekvence ásan, kde skrze vědomý dech zklidníme nervový systém, posílíme tělo a zároveň zvýšíme naši flexibilitu."
            Html.p "Každá lekce má své téma, obsahuje meditaci, pranayamu, ásanovou praxi a relaxaci."
            Html.h3 "Jaké benefity mi účast v kurzu přinese?"
            Html.p "🧘‍♀️ Stanu se součástí skupiny zapálených jogínek"
            Html.p "💬 Mohu sdílet, komentovat, ptát se"
            Html.p "💃 Jsem na cestě ke zdravému tělu a duchu"
            Html.p "💡 Rozvíjím svůj potenciál"
            Html.p "🔥 Poznávám své skutečné já"
            Html.h3 "Jak lekce probíhají?"
            Html.p "Lekce budou probíhat v uzavřené facebookové skupině. Po přihlášení Vám zašlu link k připojení se ke skupině. Pokud nemáte facebook účet, stačí si vytvořit anonymní profil jen pro účely tohoto kurzu."
            Html.p "Lekce probíhají LIVE každou středu od 19 h, nicméně ve skupině zůstanou uložené čili si je můžete pustit v čas, který si samy zvolíte."
            Html.p "Videa Vám zůstanou navždy, můžete si je tedy opakovaně pouštět kdykoliv Vám to bude vyhovovat. Skupina bude uzavřená, jak už jsem psala, tudíž nikdo neuvidí Vaše komentáře a vy můžete vesele sdílet a diskutovat dle libosti."
            Html.h3 "Týdenní témata"
            Html.p "10.3. Svobodně dýchej 🌬️"
            Html.p "17.3. Žij srdcem ❤️"
            Html.p "24.3. Stůj pevně na zemi 🦶"
            Html.p "31.3. Otevři se změně ♾️"
            Html.p "7.4. Najdi rovnováhu ☯️"
            Bulma.section [
                Bulma.columns [
                    Bulma.column [ column.is2 ]
                    Bulma.column [
                        Html.h1 [ prop.text "Rezervuj si své místo v kurzu"; prop.style [ style.marginBottom (length.rem 2) ] ]
                        emailForm state dispatch
                    ]
                    Bulma.column [ column.is2 ]
                ]
            ]
            Html.h3 "Cena"
            Html.p "Doporučená výše příspěvku za celý kurz je 550 Kč, pokud přizvete kamarádku cena za obě 1000 Kč. Pokud si v téhle covidové době nemůžete kurz dovolit, napište mi, že se chcete zúčastnit a přispějte v dobrovolné výši nebo vůbec. Ráda Vám udělám radost!"
            Html.h3 [
                text.hasTextCentered
                prop.children [
                    Html.a [ prop.text "👉 Stránky facebookové události"; prop.href "https://www.facebook.com/events/222453422751849/" ]
                    
                ]
                
            ]
        ]
        
        emptySection
        textSection [
            h1 [] [ str "Otevřené lekce"]
            h2 [] [ str "GaPa Kostelec nad Labem (v tuto chvíli neprobíhá)" ]
            yield! lessonsSection lessonsGapa
            p [ Class "info" ] [
                str "Lekce probíhají na adrese Gapa pro Vás, U Pošty 822, Kostelec nad Labem. "
                str "Cena: 50 Kč první vstup, 150 Kč jednorázový vstup, 1200 Kč permanentka na 10 vstupů (platnost 4 měsíce), 2200 Kč permanentka 20 vstupů (platnost 8 měsíců). Permanentka je nepřenosná. "
            ]
                
        ]
        textSection [
            yield h2 [] [ str "Dům jógy Vinohrady (v tuto chvíli neprobíhá)"]
            yield! lessonsSection lessonsDj
        ]
        
    ]  