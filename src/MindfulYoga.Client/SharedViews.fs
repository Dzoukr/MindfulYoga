module MindfulYoga.Client.SharedViews

open Fulma
open Fable.React
open Fable.React.Props

let emptySection = section [ Class "empty"] []

let _textSection cName c =
    section [ Class (sprintf "text section %s" cName) ] [
        Columns.columns [] [
            Column.column [ Column.Width (Screen.All, Column.IsThreeFifths); Column.Offset(Screen.All, Column.IsOneFifth )] [
                Content.content [] c
            ]
        ]
    ]

let textSection c = _textSection "" c
let textSectionCentered c = _textSection "centered" c

let in2ColTable rows =
    rows 
    |> List.map (fun (x,y) -> 
        tr [] [
            td [] [ str x ]
            td [] [ str y ]
        ]
    )
    |> tbody []
    |> List.singleton
    |> table []

let inList c =
    c 
    |> List.map (fun x ->
        li [] [
            i [ Class "fa-li fas fa-chevron-circle-right" ] [] 
            str x
        ]
    )
    |> ul [ Class "fa-ul" ]