open System

let swap (arr: array<'a>) i j  =
    let temp = arr.[i]
    arr.[i] <- arr.[j]
    arr.[j] <- temp

let shuffle array =
    let rand = Random()
    array |> Array.iteri (fun i _ -> swap array i (rand.Next(i, Array.length array)))

let array = [|1;2;3;4;5|]
shuffle array

array
|> printfn "%A"