module MindfulYoga.Client.View

open Domain
open Fulma
open Fable.React
open Fable.React.Props

let render (state : State) (dispatch : Msg -> unit) =
    div [] [
        str "FUNGUJE"
    ]