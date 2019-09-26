#r "/usr/local/share/dotnet/shared/Microsoft.NETCore.App/3.0.0/netstandard.dll"
open System

type Address =
    { State: String }

let computeSalesTax address salePrice =
    match address with
    | { State = "WA" } -> salePrice * 0.06m
    | { State = "MN" } -> salePrice * 0.75m
    | { State = "MI" } -> salePrice * 0.05m
    | _ -> salePrice * 0m