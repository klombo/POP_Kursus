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

