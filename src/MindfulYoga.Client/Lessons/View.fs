module MindfulYoga.Client.Lessons.View

open Fulma
open Fable.React
open Fable.React.Props
open MindfulYoga.Client
open SharedViews

type Lesson = {
    Title : string
    Name : string
    Description : string
}

let lessonsGapa = [
    { Title = "Pondělí, 18:15 – 19:25"; Name = "Jemná mindful yoga"; Description = "Rozvíjíme všímavost během klidně plynoucí lekce jógy. S ochotou vcítit se do svého těla, směřujeme pozornost k tomu, co prožíváme v přítomném okamžiku. Jemně se protahujeme, vědomě dýcháme a čerpáme novou energii.<br/>Jóga vhodná pro začátečníky, ale i pro pokročilé, kteří dávají přednost jemnější praxi. Vhodné i pro seniory a pro všechny se sníženou pohyblivostí, těhotné a po porodu."}
    { Title = "Pondělí, 19:40 – 20:50"; Name = "Mindful flow yoga"; Description = "Probouzíme v sobě radost a hravost během pozdravů slunci. Občas čelíme nějaké výzvě. Posilujeme střed těla, svaly kolem páteře, uvolňujeme kyčle. Vše s plným respektem k našemu tělu a rozvíjející se všímavostí k momentu TADY A TEĎ. Lekce zakončena relaxací.<br/>Dynamická lekce vhodná pro pokročilejší jogíny."}
    { Title = "Čtvrtek, 19:00 – 20:10"; Name = "Mindful easy flow"; Description = "Jemné plynutí na vlně dechu, během kterého postupně rozproudíme energii v celém těle. Zůstáváme v kontaktu s tím, co se v nás děje a pomáháme tělu přebytečné napětí a stres uvolnit. Lehce dynamická jóga se zaměřením na protažení a posílení celého těla.<br/>Vhodné pro začátečníky i pro pokročilejší jogíny."}
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

let view =
    div [ Class "lessons"] [
        
        emptySection
        textSection [
            yield h1 [] [ str "Otevřené lekce v GaPa Kostelec"]
            yield! lessonsSection lessonsGapa
            yield p [ Class "info" ] [
                str "Lekce probíhají na adrese Gapa pro Vás, U Pošty 822, Kostelec nad Labem. "
                str "Cena: 140 Kč jednorázový vstup, 1100 Kč permanentka na 10 vstupů (platnost 4 měsíce), 2100 Kč permanentka 20 vstupů (platnost 8 měsíců). Permanentka je nepřenosná. "
                str "Rezervace přes rezervační systém "
                a [ Href "https://rezervace.mindfulyoga.cz"; Class "mindful-link"] [ str "https://rezervace.mindfulyoga.cz"]
            ]
        ]

        emptySection
        textSection [
            yield h1 [] [ str "Otevřené lekce Dům jógy Vinohrady"]
            yield! lessonsSection lessonsDj
            yield p [ Class "info"] [
                str "Rezervace přes rezervační systém "
                a [ Href "https://rezervace.dum-jogy.cz/rs/"; Class "mindful-link"] [ str "https://rezervace.dum-jogy.cz/rs/"]
            ]
        ]
    ]  