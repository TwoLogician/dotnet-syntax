
let (|A|B|C|D|F|) point =
    match point / 10 with
    | 10 | 9 | 8 -> A
    | 7 -> B
    | 6 -> C
    | 5 -> D
    | _ -> F point

let check = function
    | A         -> printfn "Good"
    | B | C | D -> printfn "..."
    | F point   -> printfn "%A Haha" point

check 99
check 70
check 25

