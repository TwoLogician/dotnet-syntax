type A = {
    mutable A: int
}

let a = { A = 100 }
a.A <- 200

let c = {| A = 200; B = 300 |}