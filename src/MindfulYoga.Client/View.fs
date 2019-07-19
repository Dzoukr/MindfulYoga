module MindfulYoga.Client.View

open Domain
open Fulma
open Fable.React
open Fable.React.Props

let menu =
    
    let item (p:Router.Page) title isActive =
        Navbar.Item.a [ Navbar.Item.Option.IsActive isActive; Navbar.Item.Option.Props [ Href p.Path; OnClick Router.goToUrl ] ] [ str title]
    
    Navbar.navbar [ Navbar.Option.IsTransparent ] [
        Navbar.Brand.div [] [
            Navbar.Item.a [ Navbar.Item.Option.Props [ Href Router.AboutMe.Path; OnClick Router.goToUrl ] ] [
                img [ Src "img/logo.png" ]
            ]
            a [ Class "navbar-burger"; Data ("target","navMenu") ] [
                span [] []
                span [] []
                span [] []
            ]
        ]
        Navbar.menu [ Navbar.Menu.Option.Props [ Id "navMenu"] ] [
            Navbar.End.div [] [
                item Router.AboutMe "O mně" true
                item Router.MindfulYoga "Mindful Yoga" true
                
            ]            
        ]
    ]

let aboutMeView =
    div [ Class "lessons"] [
        section [ Class "empty"] []
        section [ Class "text" ] [
            Columns.columns [] [
                Column.column [ Column.Width (Screen.All, Column.IsThreeFifths); Column.Offset(Screen.All, Column.IsOneFifth )] [
                    Content.content [] [
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
                ]
            ]                        
        ]
        section [ Class "empty"] []
        section [ Class "text centered" ] [
            Columns.columns [] [
                Column.column [ Column.Width (Screen.All, Column.IsThreeFifths); Column.Offset(Screen.All, Column.IsOneFifth )] [
                    Content.content [] [
                        h4 [] [ str "Skutečná objevitelská cesta nespočívá v hledání nových krajů, ale ve vnímání světa novýma
                                        očima." ]
                        p [] [ str "- Marcel Proust"]                            
                    ]
                ]
            ]
        ]
        section [ Class "empty"] []

    ]

let render (state : State) (dispatch : Msg -> unit) =
    
    div [] [
        menu
        aboutMeView
    ]