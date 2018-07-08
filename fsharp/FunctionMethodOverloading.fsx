type FooInt = { thing: int } with
    static member foo (x:FooInt) =
        printfn "The int is %d" x.thing

type FooString = { label: string } with
    static member foo (x:FooString) =
        printfn "The string is %s" x.label

let inline foo (x:^t) =
    (^t: (static member foo: ^t -> unit) (x))

foo { thing = 98 }
foo { label = "Hello"}