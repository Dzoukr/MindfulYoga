module MindfulYoga.FunctionApp.Web

open Microsoft.Azure.WebJobs
open Microsoft.Extensions.Logging
open Giraffe
open Microsoft.Azure.WebJobs.Extensions.Http
open Microsoft.AspNetCore.Http
open FSharp.Control.Tasks.V2
open System.Threading.Tasks
open MindfulYoga.Shared.Communication
open System
open Fable.Remoting.Server
open Fable.Remoting.Giraffe

let myApi = {
    GetRandomInt = fun _ -> async { return Random().Next(1,999) }
}

let webApp =
    Remoting.createApi()
    |> Remoting.withRouteBuilder API.RouteBuilder
    |> Remoting.fromValue myApi
    |> Remoting.buildHttpHandler


[<FunctionName("Index")>]
let run ([<HttpTrigger (AuthorizationLevel.Anonymous, Route = "{*any}")>] req : HttpRequest, context : ExecutionContext, log : ILogger) =
    let hostingEnvironment = req.HttpContext.GetHostingEnvironment()
    hostingEnvironment.ContentRootPath <- context.FunctionAppDirectory
    let func = Some >> Task.FromResult
    task {
        let! _ = webApp func req.HttpContext
        req.HttpContext.Response.Body.Flush() //workaround https://github.com/giraffe-fsharp/Giraffe.AzureFunctions/issues/1
    } :> Task    