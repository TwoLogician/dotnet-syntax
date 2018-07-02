type Foo = { Foo: string }
type Bar = { Bar: int }

type Foo with
    static member Zoo (f: Foo) = "foo" + f.Foo;

type Bar with
    static member Zoo(b: Bar) = "bar" + string (b.Bar)

let inline zoo x =
    (^t : (static member Zoo: ^t -> string) x)

zoo { Foo = "X" }
|> printfn "%A"

zoo { Bar = 1 }
|> printfn "%A"