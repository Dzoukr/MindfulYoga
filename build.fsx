#r "paket: groupref build //"
#load "./.fake/build.fsx/intellisense.fsx"

open Fake.Core
open Fake.DotNet
open Fake.IO
open Fake.IO.FileSystemOperators

module Tools =
    let private findTool tool winTool =
        let tool = if Environment.isUnix then tool else winTool
        match ProcessUtils.tryFindFileOnPath tool with
        | Some t -> t
        | _ ->
            let errorMsg =
                tool + " was not found in path. " +
                "Please install it and make sure it's available from your path. "
            failwith errorMsg
            
    let private runTool (cmd:string) args workingDir =
        let arguments = args |> String.split ' ' |> Arguments.OfArgs
        Command.RawCommand (cmd, arguments)
        |> CreateProcess.fromCommand
        |> CreateProcess.withWorkingDirectory workingDir
        |> CreateProcess.ensureExitCode
        |> Proc.run
        |> ignore
        
    let dotnet cmd workingDir =
        let result =
            DotNet.exec (DotNet.Options.withWorkingDirectory workingDir) cmd ""
        if result.ExitCode <> 0 then failwithf "'dotnet %s' failed in %s" cmd workingDir
    
    let femto = runTool "femto"        
    let node = runTool (findTool "node" "node.exe")        
    let yarn = runTool (findTool "yarn" "yarn.cmd")

let serverSrcPath = Path.getFullName "./src/MindfulYoga.FunctionApp"
let serverWatcherPath = Path.getFullName "./src/MindfulYoga.FunctionApp.Local"
let serverDeployPath = Path.getFullName "./deploy/functionApp"
let clientSrcPath = Path.getFullName "./src/MindfulYoga.Client"
let clientDeployPath = Path.getFullName "./deploy/client"

Target.create "InstallClient" (fun _ ->
    printfn "Node version:"
    Tools.node "--version" clientSrcPath
    printfn "Yarn version:"
    Tools.yarn "--version" clientSrcPath
    Tools.yarn "install --frozen-lockfile" clientSrcPath
)

Target.create "Run" (fun _ ->
    let server = async {
        Tools.dotnet "watch run" serverWatcherPath
    }
    let client = async {
        Tools.yarn "webpack-dev-server" clientSrcPath
    }
    [client;server]
    |> Async.Parallel
    |> Async.RunSynchronously
    |> ignore
)

Target.create "PublishClient" (fun _ ->
    let clientDeployLocalPath = (clientSrcPath </> "deploy")
    [ clientSrcPath; clientDeployLocalPath] |> Shell.cleanDirs
    Tools.yarn "webpack-cli -p" clientSrcPath
    Shell.copyDir clientDeployPath clientDeployLocalPath FileFilter.allFiles
)

Target.create "PublishFunctionApp" (fun _ ->
    serverDeployPath |> Shell.cleanDir
    let publishArgs = sprintf "publish -c Release -o \"%s\"" serverDeployPath
    Tools.dotnet publishArgs serverSrcPath
)

Target.create "Publish" (fun _ ->
    ["PublishClient";"PublishFunctionApp"] |> List.iter (fun t -> Target.run 1 t [])
)

open Fake.Core.TargetOperators

"InstallClient" ==> "Run"
"InstallClient" ==> "PublishClient"    

Target.runOrDefaultWithArguments "Run"