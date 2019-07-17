module MindfulYoga.Shared.Communication

type API = {
    GetRandomInt : unit -> Async<int>
}
with
    static member RouteBuilder _ m = sprintf "/api/myAPI/%s" m