let getData() = async { 
    return 100
}

let getMoreData a = async { 
    return a + 1
}

let (>>=) x f = async.Bind(x,f) 

getData() >>= getMoreData >>= getMoreData >>= getMoreData  >>= getMoreData
|> Async.RunSynchronously 
|> printfn "%A"
