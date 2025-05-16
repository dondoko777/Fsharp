#r "paket:
nuget FAKE.Core.Target // 使用するFAKEビルドツール
nuget FAKE.DotNet.Cli"

open Fake.Core
open Fake.DotNet

Target.create "Clean" (fun _ ->
    Shell.cleanDir "./build"
)

Target.create "Build" (fun _ ->
    DotNet.build id "./src/"
)

Target.create "Test" (fun _ ->
    DotNet.test id "./tests/"
)

Target.create "Default" (fun _ ->
    Trace.trace "Build and test completed successfully!"
)

Target.runOrDefault "Default"
