module MindfulYoga.Client.Lessons.View

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
            h2 [] [ str (sprintf "%s / %s" x.Title x.Name)]
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
                prop.text "Přihlásit na lekci"
                prop.onClick (fun _ -> SendEmailForm |> dispatch)
                if model.IsSending then yield! [ button.isLoading; prop.disabled true ]
            ]
        ]
    ]

let view state dispatch =
    div [ Class "lessons"] [
        
        emptySection
        textSection [
            h1 [] [ str "Livestream lekce"]
            Html.h2 "Středy 19:30 – 20:40 / LIVEstream: Mindful Easy Flow"
            Html.p "Lekce je koncipována jako jemné plynutí na vlně dechu, během kterého vlídně rozproudíme energii v celém těle. Směřujeme pozornost k tomu, co prožíváme v přítomném okamžiku a vytváříme podmínky pro uvolnění napětí a stresu z našeho těla.
Lehce dynamická mindful jóga se zaměřením na protažení, posílení celého těla a rozvíjení naší všímavosti.
Vhodné pro začátečníky i pro pokročilejší jogíny."
            
            Html.div [
                prop.className "video-container"
                prop.dangerouslySetInnerHTML "<iframe class=\"video\" src=\"https://www.youtube.com/embed/VWfePEtnwDA\" frameborder=\"0\" allow=\"accelerometer; autoplay; encrypted-media; gyroscope; picture-in-picture\" allowfullscreen></iframe>"
            ]
            
            Html.p [
                prop.className "info"
                prop.dangerouslySetInnerHTML "Přihlášení: jana@mindfulyoga.cz nebo formulář níže.<br/>Lekce proběhne přes aplikaci ZOOM. Po přihlášení obdržíte všechny potřebné informace k připojení se na lekci."
            ]
            Html.p [
                prop.className "info"
                prop.dangerouslySetInnerHTML "NOVĚ MOŽNOST PRAKTIKOVAT I V JINÝ ČAS ☘️<br/>Pokud lekci nestihnete nebo byste rádi praktikovali později či v jiný den, pošlete mi prosím zprávu s prosbou o zaslání linku na proběhlou lekci do vaší emailové schránky."
            ]
            Html.p [
                prop.className "info"
                prop.dangerouslySetInnerHTML "Lekce probíhají za dobrovolný příspěvek.<br/>Doporučená výše příspěvku je 120 Kč za 70 min lekci, můžete zaslat méně i více, podle svého uvážení (číslo účtu 1681695016/3030) 🙏<br/>Jogínky, které mají zakoupenou permanentku, mohou na úhradu použít kredity."
            ]
            Bulma.section [
                Bulma.columns [
                    Bulma.column [ column.is2 ]
                    Bulma.column [
                        Html.h1 [ prop.text "Rezervujte si své místo na lekci"; prop.style [ style.marginBottom (length.rem 2) ] ]
                        emailForm state dispatch
                    ]
                    Bulma.column [ column.is2 ]
                ]
            ]
            
        ]
        
        emptySection
        textSection [
            yield h1 [] [ str "Otevřené lekce v GaPa Kostelec"]
            yield! lessonsSection lessonsGapa
            yield p [ Class "info" ] [
                str "Lekce probíhají na adrese Gapa pro Vás, U Pošty 822, Kostelec nad Labem. "
                str "Cena: 50 Kč první vstup, 150 Kč jednorázový vstup, 1200 Kč permanentka na 10 vstupů (platnost 4 měsíce), 2200 Kč permanentka 20 vstupů (platnost 8 měsíců). Permanentka je nepřenosná. "
            ]
            yield
                Html.p [
                    prop.className "cta"
                    prop.children [
                        Bulma.buttonLink [
                            button.isPrimary
                            button.isMedium
                            prop.target "_blank"
                            prop.href "https://rezervace.mindfulyoga.cz"
                            prop.text "Přihlásit se na lekci"
                        ]
                    ]
                ]
        ]

        emptySection
        textSection [
            yield h1 [] [ str "Otevřené lekce Dům jógy Vinohrady"]
            yield! lessonsSection lessonsDj
            yield
                Html.p [
                    prop.className "cta"
                    prop.children [
                        Bulma.buttonLink [
                            button.isPrimary
                            button.isMedium
                            prop.href "https://rezervace.dum-jogy.cz/rs/kalendar_vypis/instruktor/88"
                            prop.text "Přihlásit se na lekci"
                        ]
                    ]
                ]
        ]
        
    ]  