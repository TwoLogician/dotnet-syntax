open System
open System.Linq.Expressions

type A() =
    static member  F1 e = (e: Expression<Func<int,int>>).Compile()

let f1 e = (e: Expression<Func<int,int>>).Compile()

A.F1(fun x -> x * 2).Invoke(2)

f1(fun x -> x * 2).Invoke(2)