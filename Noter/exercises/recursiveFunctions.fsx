// Define a function that takes an integer as parameter and returns its factorial

let rec factorial (num: int): int =
    if num <= 1 then 1
    else num * factorial (num-1)

factorial 5 |> printfn "The factorial of 5 is: %A"

// Define a function that an integer and returns a list containing the 
// Fibonacci sequence up to that number

let rec fibonacci (num: int): int list =
    if num <= 0 then []
    elif num = 1 then [0]
    elif num = 2 then [0; 1]
    else
        let prev = fibonacci (num - 1)
        prev @ [prev[num - 2] + prev[num - 3]]

fibonacci 8 |> printfn "The Fibonacci sequence list: %A"

// Define a function that takes two ints and returns their greatest common divisor

let rec gcd (x: int) (y: int): int =
    if y = 0 then x
    else gcd y (x % y)

gcd 12 4 |> printfn "The greatest common divisor of 12 and 4 is: %A"

//
//
// Rewrite these functions with pattern matching instead of else if statements
//
//

// Define a function that takes an integer as parameter and returns its factorial

let rec factorialPattern (num: int): int =
    match num with
    |0|1 -> 1
    | _ -> num * factorialPattern (num - 1)

factorialPattern 5 |> printfn "The factorial of 5 is: %A"

// Define a function that an integer and returns a list containing the 
// Fibonacci sequence up to that number

let rec fibonacciPattern (num: int): int list =
    match num with
    | num when num <= 0 -> []
    | 1 -> [0]
    | 2 -> [0; 1]
    | _ -> 
        let prev = fibonacciPattern (num - 1)
        prev @ [prev[num - 2] + prev[num - 3]]

fibonacciPattern 8 |> printfn "The Fibonacci sequence list: %A"

// Define a function that takes two ints and returns their greatest common divisor

let rec gcdPattern (x: int) (y: int): int =
    match y with
    | 0 -> x
    | _ -> gcdPattern y (x % y)

gcdPattern 12 4 |> printfn "The greatest common divisor of 12 and 4 is: %A"