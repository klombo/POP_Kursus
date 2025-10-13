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