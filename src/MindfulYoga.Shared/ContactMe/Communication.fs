module MindfulYoga.Shared.ContactMe.Communication

open MindfulYoga.Shared.Communication
open Domain

type ContactMeService = {
    SendEmail : EmailForm -> ServerResponse<unit>
}
with
    static member RouteBuilder _ m = sprintf "/api/ContactMe/%s" m