
type Currency =
    CAD | USD | GBP
    member t.Name =
        match t with
        | CAD -> "Canadian dollar"
        | USD -> "United States dollar"
        | GBP -> "Pound sterling"
    member t.Country =
        match t with
        | CAD -> "Canada"
        | USD -> "United state"
        | GBP -> "South Georgia Island"

let f1(c: Currency) =
    printfn "country = %s" (c.Country)
    printfn "name = %s" (c.Name)

f1(CAD)
f1(USD)


