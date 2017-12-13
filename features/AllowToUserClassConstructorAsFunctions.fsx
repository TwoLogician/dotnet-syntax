let uri = 
    "https://github.com/fsharp/fslang-suggestions/issues/158"
    |> System.Uri

uri.LocalPath |> printfn "%A"
uri.Host |> printfn "%A"
uri.AbsolutePath |> printfn "%A"
uri.AbsoluteUri |> printfn "%A"