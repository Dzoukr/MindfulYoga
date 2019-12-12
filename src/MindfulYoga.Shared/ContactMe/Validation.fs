module MindfulYoga.Shared.ContactMe.Validation

open Domain
open MindfulYoga.Shared
open MindfulYoga.Shared.Validation

let validateForm (l:EmailForm) =
    [
        nameof(l.Email), validateNotEmpty l.Email
        nameof(l.Email), validateEmail l.Email
        nameof(l.Name), validateNotEmpty l.Name
    ]
    |> Validation.validate
