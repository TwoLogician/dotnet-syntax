type IAnimal =
    abstract member Name: string

type Dog (name: string) =
    interface IAnimal with
        member __.Name = name

let dog:IAnimal  = upcast (Dog "Pluto")

let name = dog.Name
name
|> printfn "%A"