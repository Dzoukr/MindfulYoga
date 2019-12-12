module MindfulYoga.Shared.Communication

type NewslettersService = {
    Subscribe : string -> Async<unit>
}
with
    static member RouteBuilder _ m = sprintf "/api/NewslettersAPI/%s" m
    
open Validation

type ServerError =
    | Exception of string
    | Validation of ValidationError list

type ServerResult<'a> = Result<'a, ServerError>

module ServerResult =
    let ofValidation (validationFn:'a -> ValidationError list) (value:'a) : ServerResult<'a> =
        match value |> validationFn with
        | [] -> Ok value
        | errs -> errs |> Validation |> Error

type ServerResponse<'a> = Async<ServerResult<'a>>    