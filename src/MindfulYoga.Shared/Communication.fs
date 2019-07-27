module MindfulYoga.Shared.Communication

type NewslettersAPI = {
    Subscribe : string -> Async<unit>
}
with
    static member RouteBuilder _ m = sprintf "/api/NewslettersAPI/%s" m