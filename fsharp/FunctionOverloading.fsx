type T = T with
    static member ($) (T, n: int) = n.ToString("D10")
    static member ($) (T, n: string) = n.ToString()

let inline foo (x: 't) = T $ x


foo 100 |> printfn "%A"
foo "100" |> printfn "%A"