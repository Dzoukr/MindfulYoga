module MindfulYoga.Client.Lessons.View

open Fulma
open Fable.React
open Fable.React.Props
open MindfulYoga.Client
open SharedViews


let view =
    let contact = a [ Href Router.Contact.Path; OnClick Router.goToUrl ] [ str "Rezervovat"]
    div [ Class "lessons"] [
        textSection [
            Columns.columns [] [
                Column.column [ Column.Option.Width (Screen.All, Column.Is12) ] [

                    h1 [] [ str "LETNÍ MINDFUL YOGA V PARCÍCH"]
                    h3 [] [ str "Červenec 2019"]
                    p [] [
                        strong [] [ str "Pondělí 22.7." ]
                        str " Park nám. Odboje, Kostelec nad Labem, 19:00 – 20:10, cena 110Kč/70min. "
                        contact
                        br []
                        
                        strong [] [ str "Čtvrtek 25.7." ]
                        str " Park Grébovka, Praha 2, 18:00 – 19:00 "
                        a [ Href "https://dum-jogy.cz/akce-a-balicky/joga-v-parku-grebovka.html" ] [ str "Více info"]
                        br []

                        strong [] [ str "Pondělí 29.7." ]
                        str " Park nám. Odboje, Kostelec nad Labem, 19:00 – 20:10, cena 110Kč/70min. "
                        contact
                        br []
                    ]

                    h3 [] [ str "Srpen 2019"]
                    p [] [
                        strong [] [ str "Pondělí 5.8." ]
                        str " Zámecký park Ctěnice, Praha 9 19:00 – 20:10, cena 110Kč/70min. "
                        contact
                        br []

                        strong [] [ str "Úterý 6.8." ]
                        str " Park na Vyšehradě, Praha 2, 18:00 – 19:00 "
                        a [ Href "https://dum-jogy.cz/akce-a-balicky/joga-na-vysehrade.html" ] [ str "Více info"]
                        br []

                        strong [ Class "strikethrough" ] [ str "Pondělí 12.8." ]
                        strong [] [ str " PŘESUNUTO NA STŘEDU 14.8." ]
                        str " Park nám. Odboje, Kostelec nad Labem, 19:00 – 20:10, cena 110Kč/70min. "
                        contact
                        br []

                        strong [] [ str "Pondělí 26.8." ]
                        str " Park nám. Odboje, Kostelec nad Labem, 19:00 – 20:10, cena 110Kč/70min. "
                        contact
                        br []
                    ]
                ]
            ]
        ]
    ]