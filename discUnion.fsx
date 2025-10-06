type IntOrNaN =
    | Value of int
    | NaN

let divide (x: int) (y: int) : IntOrNaN=
    if y = 0 then NaN
    else Value (x/y)

let plus (x: IntOrNaN) (y: IntOrNaN) : IntOrNaN =
    match x,y with
    | Value x, Value y -> Value (x+y)
    |_ -> NaN
 
plus (Value 8) (Value 3) |> printfn "%A"

        