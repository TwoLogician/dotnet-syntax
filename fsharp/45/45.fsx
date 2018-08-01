
open System

let a = ref 0

Int32.TryParse("100a", a)

printfn "%A" a.Value