# Deliberate_Practice_W3
#### Exercises:
#### 1. Tuples and lists (Review let bindings)
The `.fsx` file doesn't exist  

Topics: #types/tuples #types/lists #types/declaration

- Define a let binding for a tuple composed of a string and an integer
``` fsharp
let tupleOfStringAndInt = ("Hello" * 1)
```

- Define a let binding for a tuple composed of a string and an integer
``` fsharp
let tupleOfStringAndInts = ("Hello" * 1 * 2 * 3 * 4)
```

- Define a let binding for a tuple composed of a string and a list of integers
``` fsharp
let tupleOfStringAndList = ("Hello" * [1;2;3;4])
```

- Define a function that takes as input a list of tuples composed of a string and an integer and returns a list composed of the strings extracted from the input tuples

``` fsharp
let rec extractString (tuplelist: (string * int) list) : int list =
    match tuplelist with
    | [] -> []
    | head::tail -> snd head :: extractString tail
    
let listOfTuples = [("hej", 1); ("hello", 2); ("goddav", 4)]
extractString listOfTuples |> printfn "%A"
```

- Define a let binding for a list of 4 lists of integers
``` fsharp
let listOfFourIntLists = [[1;2;3];[11;12;13];[21;22;23];[31;32;33]]
```

- Define a function that takes as input a list of list of integers and returns a list containing all the integers in the input
``` fsharp
let rec extractListOfInts (listOfInts: int list list) : int list =
    match listOfInts with
    | [] -> []
    | head::tail -> head @ extractListOfInts tail

let Ints = [[41; 1]; [40; 2]; [38; 4]]
extractListOfInts Ints |> printfn "%A" 
```

#### 2. Strings (Review let bindings)
The `.fsx` file doesn't exist  

Topics: #types/strings #types/declaration

- Define a let binding s for the string `"Hello World!"`
``` fsharp
let s = "Hello World"
```

- Define a let binding for the first character of s
``` fsharp
let firstCharOfs = s.[0] //output H
```

- Define a let binding for the first 5 characters of s
``` fsharp
let firstFiveCharsOfs = s.[0..4] //output Hello
```

- Define a let binding for the length of the string s
``` fsharp
let lengthOfs = s.Length //output 11
```

- Define a let binding for the last character of s
``` fsharp
let lastCharOfs = s.[s.Length-1]//output d
```

- Define a function that takes as input a list of string and returns the concatenation of these strings
``` fsharp
let concantenateString (listOfStrings : string list) : string =
	match listOfStrings with
	| [] -> ""
	| head::tail -> head + concantenateString tail
```

#### 3. Pattern matching
The `.fsx` file is  [`recursiveFunctions.fsx`](exercises/recursiveFunctions.fsx)
Topics: #functions/recursion #pattern-matching

You should revisit the recursive functions you wrote in [[Deliberate_Practice_W2|Deliberate Practice - week 2]].

- Using pattern matching, re-write the recursive function that takes an integer as parameter and returns its factorial
``` fsharp
let rec factorialPattern (num: int): int =
    match num with
    |0|1 -> 1
    | _ -> num * factorialPattern (num - 1)

factorialPattern 5 |> printfn "The factorial of 5 is: %A"
```

- Using pattern matching, re-write the recursive function that takes an integer and returns a list containing the Fibonacci sequence up to that number
``` fsharp
let rec fibonacciPattern (num: int): int list =
    match num with
    | num when n <= 0 -> []
    | 1 -> [0]
    | 2 -> [0; 1]
    | _ ->
        let prev = fibonacciPattern (num - 1)
        prev @ [prev[num - 2] + prev[num - 3]]

fibonacciPattern 8 |> printfn "The Fibonacci sequence list: %A"
```

- Using pattern matching, re-write the recursive function that takes two integers as parameters and returns their greatest common divisor
``` fsharp
let rec gcdPattern (x: int) (y: int): int =
    match y with
    | 0 -> x
    | _ -> gcdPattern y (x % y)

gcdPattern 12 4 |> printfn "The greatest common divisor of 12 and 4 is: %A"
```

#### 7. Higher order functions on Lists
The `.fsx` file doesn't exist
Topics: #functions/higher-order #types/lists

Consider the following list in F#:
```fsharp 
let l = [1;2;3;4] 
```

- Write an expression that returns a new list where all that value of each element in the list is increased by 1
``` fsharp
l |> List.map (fun x -> x + 1)
```

- Write an expression that prints each element in the list 
``` fsharp
l |> List.iter (fun x -> x |> printfn "%A")
```

- Write an expression that returns a new list with only even numbers
- Write an expression that returns a new list with only odd numbers
``` fsharp
l |> List.filter (fun x -> x % 2 = 0)
l |> List.filter (fun x -> not(x % 2 = 0))
```

- Write an expression that returns a new list where each element is converted to float
``` fsharp
l |> List.map (fun x -> float x)
```

Consider the following list in `F#`:
```fsharp 
let l = [1..100]
```

- Write an expression that partitions this list in even and odd numbers
``` fsharp
l |> List.groupBy (fun n -> n % 2)
```

- Write an expression that partitions this list in integers greater than 50 and those lower than or equal to 50.
``` fsharp
l |> List.groupBy (fun n -> n > 50)
```
