# Worksheet_W1 4-9-25

Topics: 
#functions/declaration #types/tuples 
#### Exercises:
##### 1. Average
The `.fsx` file doesn't exist
The brief description of the function avg below is that it return the average of two numbers:
``` fsharp
let avg (x: int) (y: int) : int =
	let average = (x + y)/2
	average
```
Modify the function based on the follow refined description: It should return the average of two floating point numbers:
``` fsharp
let avg (x: float) (y: float) : float =
	let average = (x + y)/2.0
	average
```
##### 2. Rational Numbers
The `.fsx` file is [`rationNumbers.fsx`](exercises/rationalNum.fsx)
``` fsharp
let qplus (a : int, b: int) (c: int, d: int) : (int * int) =
    ((a*d + b*c), b*d)

let qminus (a : int, b: int) (c: int, d: int) : (int * int) =
    ((a*d-b*c), b*d)

let qmul (a : int, b: int) (c: int, d: int) : (int * int) =
    (a*c, b*d)

let qdiv (a : int, b: int) (c: int, d: int) : (int * int) =
    (a*d, b*c)

let toString (a: int, b: int) : string =
    string a + "/" + string b  

printfn "1/2 + 1/3 = %s" (toString (qplus (1,2) (1,3)))
```
Express the following arithmetic expressions in rationals.fsx
2/3 - 3/2  
1/4 + 3/4 + 1/2  
3/4 - (3/2 * 1/2)
```fsharp
// 2/3 - 3/2
printfn "2/3 - 3/2 = %s" (toString (qminus (2,3) (3,2)))
// 1/4 + 3/4 + 1/2
printfn "1/4 + 3/4 + 1/2 = %s" (toString (qplus (1,4) (qplus(3,4) (1,2))))
// 3/4 - (3/2 * 1/2) 
printfn "3/4 - (3/2 * 1/2) = %s" (toString (qminus (3,4) (qmul(3,2) (1,2))))
```