let getData() = async { 
    return 100
}

let getMoreData a = async { 
    return a + 1
}

async { 
    let! a = getData()
    let! b = getMoreData a
    let! c = getMoreData b
    let! d = getMoreData c
    let! e = getMoreData d
    return e
}

let (>>=) x f = async.Bind(x,f) 

getData() >>= getMoreData >>= getMoreData >>= getMoreData  >>= getMoreData
|> Async.RunSynchronously 
|> printfn "%A"
