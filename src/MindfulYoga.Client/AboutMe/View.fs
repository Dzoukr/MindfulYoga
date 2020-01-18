module MindfulYoga.Client.AboutMe.View

open Fulma
open Fable.React
open Fable.React.Props
open MindfulYoga.Client
open SharedViews

let view =
    div [ Class "aboutme"] [
        emptySection
        figure [ Class "image mobile-only"] [
            img [ Src "img/aboutme_bg.jpg"]
        ]
        textSection [
            h1 [] [ str "Můj příběh"]
            p [] [
                str "Poprvé jsem se setkala s jógou na začátku mého studia na vysoké škole, kdy jsem
                    sezením nad knížkami trávila dlouhé hodiny. Přišly bolesti zad, ztuhlá krční páteř
                    a od té velmi časté bolesti hlavy spojené také s notnou dávkou stresu. V té době mi
                    jóga s mými zdravotními problémy hodně pomáhala."
            ]
            p [] [
                str "Po vystudování Vysoké školy ekonomické v Praze jsem se po hlavě vrhla do
                    zaměstnání s vidinou slibné kariéry. Zanedlouho jsem pocítila, že tudy zřejmě má
                    cesta nepovede. Uspokojené ego si sice libovalo na pozici manažera, ale
                    nedokázalo vykompenzovat notnou dávku stresu a spěchu v každodenním životě."
            ]
            p [] [
                str "Narodily se mi dvě dcery a já měla dostatek času si promýšlet, co dál. A jelikož mě
                    jóga bavila a chtěla jsem ji studovat více do hloubky, rozhodla jsem se pro lektorský
                    kurz. Jak jinak se člověk nejvíce o něčem dozví a naučí, než že se rozhodne to učit."
            ]
            p [] [
                str "Začala moje cesta objevování a poznávání sama sebe, zjišťování, kdo vlastně jsem a
                    čemu se chci v životě věnovat."
            ]
            p [] [
                str "V roce 2016 jsem začala jógu učit. Byl to takový startovací můstek pro různá další
                    školení a hledání, co jóga znamená pro mě samou. Meditace v té době byla pro mě
                    něco naprosto nedosažitelného, nicméně něco mě na ní pořád lákalo. Přečetla jsem
                    hodně knih, ale sednout si a meditovat, se mi nedařilo. Řekla jsem si, že pro začátek
                    by mi mohl pomoci nějaký kurz, skupina podobně smýšlejících lidí se zájmem o
                    stejnou věc."
            ]
            p [] [
                str "V roce 2017 jsem prošla prvním meditačním kurzem. Zlomový byl pro mne ale až
                    opět lektorský kurz RMT (Relation Mindfulness Training), kdy jsem se začala zabývat
                    Mindfulness neboli meditací všímavosti. Během každodenních meditací jsem si
                    uvědomila, jak cenný nástroj poznání meditace je."
            ]
            p [] [
                str "Několik měsíců mi vrtalo hlavou, jak meditaci začlenit do lekcí jógy, jak jógovou praxi
                    obohatit, aby přinášela co největší užitek. V hlavě mi zrála myšlenka o propojení
                    meditace (mindfulness) s tělem a pohybem, až se jednoho krásného letního dne
                    zrodil nápad "
                a [ Class "mindful-link"; Href Router.MindfulYoga.Path; OnClick Router.goToUrl ] [ str "mindful yogy®"]
                str "."
            ]
            p [] [
                str "Jóga je především o seberozvoji. Učí nás mít se rád, přijímat se a otevřít se… sobě i
                    celému světu."
            ]
            p [] [
                str "Cílem je nacházet vlastní cestu, žít svůj život a prožívat ho s lehkostí a klidnou myslí.
                    S radostí pozoruji pokroky svých studentů, a i když výchozí pozici nemáme všichni
                    stejnou, každý se může posouvat kupředu. Vše přijde v ten správný čas."
            ]
            p [] [
                str "Učme se vděčnosti, laskavosti a lásce k sobě i ke svému okolí."
            ]
            p [] [
                str "Ze srdce děkuji všem svým učitelům, minulým, současným i budoucím. Děkuji své
                    rodině, mým dětem a přátelům … a Vám všem, svým klientům, i díky Vaší zpětné
                    vazbě vím, že jsem na té správné cestě, a to mě posouvá stále dál."
            ]
            p [] [
                str "Žít všímavě, znamená vést bohatý život."
            ]
            p [] [
                str "Namasté"
                br []
                str "Jana"
            ]
        ]
        emptySection
        textSectionCentered [
            h4 [] [ str "Skutečná objevitelská cesta nespočívá v hledání nových krajů, ale ve vnímání světa novýma očima." ]
            p [] [ str "- Marcel Proust"]                            
        ]
        emptySection
        textSection [
            h1 [] [ str "Vzdělání"]
            [
                "2020-24", "Pražská vysoká škola psychosociálních studií, Daseinsanalytický psychoterapeutický výcvik"
                "2019", "Meditační ústraní, Jeff Oliver (AUS)"
                "2019", "Úvod do zaklánění, Dalibor Štedronský"
                "2018/2019", "Roční výcvik pro lektory programu Relational Mindfulness Training (RMT), Jan Burian, Marek Vich"
                "2018", "Stoje na rukách, Klára Pokorná"
                "2018", "Umění jógového dotyku (techniky adjustementu), Ladislav Pokorný, Ánanda Ashtanga Yoga Shala"
                "2018", "Hlas dokořán – vědomá práce s hlasem, Monika Obermajerová"
                "2018", "Zdravá jóga aneb nejčastější chyby při nastavování jógových pozic, Mgr. Daniel Müller, IQ pohyb Akademie"
                "2017", "Yin Yoga training, Certificate of Training Yin Yoga Teacher, 50 HR Yoga Alliance, Angela Jervis-Read, Yogacentrum in Prague"
                "2017", "Zdravá ramena, Lucie Konigová"
                "2017", "Kurz čakra jóga, Barbora Hu"
                "2017", "Jóga pro seniory, FISAF"
                "2016", "Hatha yoga training, Certificate of Training Hatha Yoga Teacher, 200 HR of in-class instruction and 100 HR of independent study, RYT Yoga Alliance Yogacentrum in Prague"
                "2012", "Reiki 1. stupeň podle systému Dr. Mikao Usui, Martina Scales, Centrum Effeta"
            ] |> in2ColTable
        ]
    ]