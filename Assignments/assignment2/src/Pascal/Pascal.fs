module Pascal 

type IntOrNaN =
    | Value of int
    | NaN

let rec pascal (n : int, k : int) : IntOrNaN =
    match n,k with
    | n,k when k > n || n < 0 || k < 0 -> NaN
    | n,k when n = k || k = 0 -> Value 1
    | n,_ when n > 33 -> NaN
    | n,k -> match pascal (n-1, k-1), pascal (n-1,k) with
                | Value x, Value y -> Value (x + y)
                | _, NaN -> NaN
                | NaN,_ -> NaN

let pascalNoRec ((n, k) : int * int) : IntOrNaN =
    if n < 0 || k < 0 || k > n then NaN
    elif n = k || k = 0 then Value 1
    elif n > 33 then NaN
    else // Pascals triangle is initilazed at zero therefore it is n + 1
        let mutable triangle = Array.init (n+1) (fun index -> Array.zeroCreate (index+1))
        for row in 0..n do
            for column in 0..row do
                if column = 0 || column = row then 
                    triangle.[row].[column] <- 1
                else
                    triangle.[row].[column] <- triangle.[row-1].[column-1] + triangle.[row-1].[column]
    
        Value triangle.[n].[k]
            