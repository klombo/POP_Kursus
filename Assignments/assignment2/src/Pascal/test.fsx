type IntOrNaN =
    | Value of int
    | NaN

let rec pascal (n : int, k : int) : IntOrNaN =
    match n,k with
    | n,k when k > n || n < 0 || k < 0 -> NaN
    | n,k when n = k || k = 0 -> Value 1
    | n,_ when n > 33 -> NaN
    | n,k -> match pascal (n-1, k-1), pascal (n-1,k) with
                | Value x, Value y when x > 1073741823 && y > 1073741823 -> NaN
                | Value x, Value y -> Value (x + y)
                | _, NaN -> NaN
                | NaN,_ -> NaN

let hasPropertyTwo ((n,k) : int * int) : bool =
    if (n > k && k > 0) then
        pascal(n,k) = match pascal (n-1, k-1),  pascal (n-1,k) with
                        | Value x, Value y -> Value (x + y)
                        | _, NaN -> NaN
                        | NaN,_ -> NaN
    else false

hasPropertyTwo ((34,17)) |>  printfn "%A"
pascal ((33,16)) |> printfn "%A"
pascal ((33,17)) |> printfn "%A"