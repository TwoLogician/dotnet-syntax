let (Some v1) = Some 11
v1 = 11 |> printfn "%A"


type ('a, 'b) Either = This of 'a | That of 'b

let this10 = This 10
let that10 = That 10 

let (This a | That a) = this10

a |> printfn "%A" 