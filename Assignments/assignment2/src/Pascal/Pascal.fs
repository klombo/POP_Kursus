module Pascal 

type IntOrNaN =
    | Value of int
    | Error of string

let rec pascal (n : int, k : int) : IntOrNaN =
    match n,k with
    | n,k when k > n || n < 0 || k < 0 || n > 10000 -> Error "Invalid Input"
    | n,k when n = k || k = 0 -> Value 1
    | n,k -> match pascal (n-1, k-1), pascal (n-1,k) with
                | Value x, Value y when x + y < 0 -> Error "Overflow Output"
                | Value x, Value y -> Value (x + y)
                | _, Error e -> Error e
                | Error e,_ -> Error e

let pascalNoRec ((n, k) : int * int) : IntOrNaN =
    if n < 0 || k < 0 || k > n || n > 100000 then Error "Invalid Input"
    elif n = k || k = 0 then Value 1
    else // Pascals triangle is initilazed at zero therefore it is n + 1
        let mutable triangle = Array.init (n+1) (fun index -> Array.zeroCreate (index+1))
        for row in 0..n do
            for column in 0..row do
                if column = 0 || column = row then 
                    triangle[row][column] <- 1
                else
                    if triangle[row-1][column-1] + triangle[row-1][column] < 0 || triangle[row-1][column-1] = 0 || triangle[row-1][column] = 0 then
                        triangle[row][column] <- 0
                    else
                        triangle[row][column] <- triangle[row-1][column-1] + triangle[row-1][column]

        if triangle[n][k] = 0 then
            Error "Overflow Output"
        else
            Value (triangle[n][k])
            