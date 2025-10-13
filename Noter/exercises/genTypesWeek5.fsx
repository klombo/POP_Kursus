type Pair<'T> = ('T * 'T)
let x Pair = (4,3)
let y Pair = (3.0,2.0)
let z Pair = ("povl", "eric")

let printGenType (x: 'a) = printfn "%A" x

let printGenList (x: 'a list) = x.[0]

let printGenArray (x: 'a array) = x.[0]