open System
#r "../src/ByRef/obj/Debug/net45/ByRef.dll"

open ByRef

let (ok, value) = MyInt.TryAdd("100", "200")

printfn "%A %A" ok value

let (|Interger|_|) str =
    match Int32.TryParse str with
    | (true, value) -> Some value
    | _ -> None

let (|Float|_|) str =
    match Double.TryParse str with
    | (true, value) -> Some value
    | _ -> None


