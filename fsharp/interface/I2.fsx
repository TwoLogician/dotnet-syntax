type IA = interface end
type IB = interface end

type First() =
    interface IA
    interface IB
type Second() =
    interface IA
    interface IB

let test =
    if 1 = 1 then First()
    else Second()