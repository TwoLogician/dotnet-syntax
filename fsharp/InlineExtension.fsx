type Foo = { Foo: string }
type Bar = { Bar: int }

type Foo with
    static member Zoo (f: Foo) = "foo"

type Bar with
    static member Zoo(b: Bar) = "bar"

let inline zoo(x: ^t) =
    (^t : (static member Zoo: ^t -> string) x)

zoo { Foo = "1 "}
|> printfn "%A"

zoo { Bar = 1 }
|> printfn "%A"