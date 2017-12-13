
type Str = { A: string }
module Str = 
    let small (x: string) = x.ToLower()

type 'a Foo  = { Value: 'a }

module Foo = 
    let add (x: Foo<'a>) (y: Foo<'a>) = { Value = x.Value + y.Value }

module X = 
    Str.small "100" |> printfn "%A"

    Foo.add { Value = 100 } { Value = 200 }
    |> printfn "%A"