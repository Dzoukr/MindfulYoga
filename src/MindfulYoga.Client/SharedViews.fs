module MindfulYoga.Client.SharedViews

open Fulma
open Fable.React
open Fable.React.Props
open MindfulYoga.Shared.Communication
open MindfulYoga.Shared.Validation

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
            i [ Class "fa-li fab fa-gratipay" ] [] 
            str x
        ]
    )
    |> ul [ Class "fa-ul" ]
    
let inP txt = p [] [ str txt ]

let inPraw txt = p [ DangerouslySetInnerHTML { __html = txt }] [ ]

module ErrorViews =
    open Elmish
    open Elmish.Toastr
    
    let showError (e:ServerError) : Cmd<_> =
        let basicToaster =
            match e with
            | Exception msg ->
                Toastr.message msg
                |> Toastr.title "Došlo k chybě"
            | Validation v ->
                v
                |> List.map (fun x -> x.Field, ValidationErrorType.explain x.Type)
                |> List.map (fun (n,e) -> sprintf "%s : %s" n e)
                |> String.concat "<br/>"
                |> Toastr.message
                |> Toastr.title "Data nejsou vyplněna správně"
                |> Toastr.timeout 30000
                |> Toastr.extendedTimout 10000
                
        basicToaster
        |> Toastr.position ToastPosition.TopRight
        |> Toastr.hideEasing Easing.Swing
        |> Toastr.withProgressBar
        |> Toastr.showCloseButton
        |> Toastr.error
    
    let showResult (er:ServerResult<_>) =
        match er with
        | Error e -> showError e
        | Ok _ -> Cmd.none

module ValidationViews =

    open MindfulYoga.Shared.Validation
    open Feliz
    open Feliz.Bulma

    let help errors name =
        errors
        |> List.tryFind (fun x -> x.Field = name)
        |> Option.map (fun x ->
            Bulma.help [
                help.isDanger
                prop.text (x.Type |> ValidationErrorType.explain)
            ]
        )
        |> Option.defaultValue Html.none

    let color errors name =
        errors
        |> List.tryFind (fun x -> x.Field = name)
        |> Option.map (fun _ -> input.isDanger)
        |> Option.defaultValue (Interop.mkAttr "dummy" "")
    