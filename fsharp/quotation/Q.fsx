open System
open System.Linq.Expressions
open Microsoft.FSharp.Linq.RuntimeHelpers

type Expr = static member Quote e = e: Expression<Func<int, int>>

let two = 2
let m = Expr.Quote(fun x -> x * two).Compile()
let q  =
    let expr =
        <@ Func<_,_> (fun x -> x * two) @>
        |> LeafExpressionConverter.QuotationToExpression
        |> unbox<Expression<Func<int,int>>>
    expr.Compile()

#time
m.Invoke(4)
#time

#time
q.Invoke(4)
#time





