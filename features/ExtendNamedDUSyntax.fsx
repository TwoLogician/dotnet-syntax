
type DU = 
    | Case1 of Prop1: string * Prop2:int * Prop3: bool
    | Case2

let c1 = Case1 ("p1", 20, true)

match c1 with
| Case1 (Prop1 = p1 ; Prop2 = p2 ; Prop3 = p3) ->
    printfn "match %A %A %A" p1 p2 p3
| _ -> printfn "unmatch"