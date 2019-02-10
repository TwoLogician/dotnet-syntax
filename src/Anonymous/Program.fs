// Learn more about F# at http://fsharp.org

open System

[<EntryPoint>]
let main argv =

    let a = {| X = 1; Y = 2 |}
    let b = {| a with Z = 3 |}
    printfn "%A" a
    printfn "%A" b

    0 // return an integer exit code
