# Deliberate_Practice_W2

#### Exercises:
#### 1. Function declarations in F# interactive
The `.fsx` file doesn't exist.
Topics:  #functions/declaration #functions/higher-order

- define a function that takes a boolean as argument and prints "Hello World!" if the parameter is true
``` fsharp
let f (x: bool) = 
	if x = true then printfn("Hello World")
```

- define a function that takes an integer as parameter and prints "Hello World!" if the parameter is greater than 5
``` fsharp
let f (x: int) =
	if x > 5 then printfn("Hello World")
```

- define a function that takes an integer as parameter and prints "Hello World!" if the parameter is not equal to 0
``` fsharp
let f (x: int) =
	if not(x=0) then printfn("Hello World")
```

- define a function that takes two boolean parameters and prints "Hello World!" if both parameters are false
``` fsharp
let f (x: bool) (y: bool) =
	if x = false && y = false then printfn ("Hello World")
```

- define a function f that takes two integers and returns their sum; declare a function g that takes two floats as parameters and returns their sum using f
``` fsharp
let f (x: int) (y: int) =
	let a = x + y
	prinftn "%d" a

let g (a: float) (y: float) =
	let sum = f(int a, int b)
	prinftn "%f" (float sum)
```

- (advanced) define a function f that takes an integer x as parameter and returns a function that takes an integer y as parameter and adds x to it. Give an example of how function f is called.
``` fsharp
let f (x: int) =
	fun (y: int) -> x + y

let add6 = f 6
let result = add5 10
```
#### 2. Working with lists
The `.fsx` file doesn't exist.
Topics:  #types/lists

- bind a name l to a list composed of the first 20 integers starting at 1
``` fsharp
let l = [1..20]
```

- bind a name ll to a list composed of all integers between 12 and 42
``` fsharp
let ll = [13..41]
```

- what is the length of the list ll?
	- The length is 29

- What is the first element of the list ll=
	- 13

- create a list lll obtained by removing the first element from the list ll
``` fsharp
let lll = ll.tail
```

- define a function that takes one argument and returns a list composed of this element
``` fsharp
let listOfElement (x: 'a) =
	x :: []
```

- define a function that  takes a list of strings as parameter and returns a boolean indicating whether the list is empty or not. Define this function without using list properties.
``` fsharp
let isListEmpty (inputList: string list) =
	if inputList = [] then true
	else false
```

- define a function that  takes a list of strings as parameter and returns a boolean indicating whether the list is empty or not. Define this function without using if then else.
``` fsharp
let isListEmpty (inputList: string list) =
	inputList.IsEmpty
```
#### 3. Reading from stdin
The `.fsx` file doesn't exist.
Topics:  #stdin

- read a line containing a string from stdin
``` fsharp
let readline =
	let x = string(System.Console.Readline)
	
	printfn("%s" x)
```

- read two lines from stdin, one containing one string and the other containing one int
``` fsharp
let readline =
	let x = string(System.Console.Readline)
	let y = string(System.Console.Readline)
	let z = int y
	
	printfn("Min String er %s og min int er %d" x z)
```

- read two lines containing two strings each; print the second string of each line
``` fsharp
let readline =
	let line1 = System.Console.ReadLine().Split(' ')
	let line2 = System.Console.ReadLine().Split(' ')
	printfn "%s" line1.[1]
	printfn "%s" line2.[1]
```

- read one line containing 4 integers; print their sum
``` fsharp
let readline =
	let numbers = System.Console.ReadLine().Split(' ') 
	let sum = int numbers[0] + int numbers[1] + int numbers[2] + int numbers[3]
	printfn "%d" sum
```
#### 4. Recursion
The `.fsx` file is  [`recursiveFunctions.fsx`](exercises/recursiveFunctions.fsx)
Topics:  #functions/recursion
- define a recursive function that  takes an integer as parameter and returns its factorial
``` fsharp
let rec factorial (num: int): int = 
	if num <= 1 then 1
	else num * factorial (num - 1)
	
factorial 5 |> printfn "%A"
```

- define a recursive function that takes an integer as parameter and returns a list containing the Fibonacci sequence up to that number
``` fsharp
let rec fibonacci (num: int): int list =
	if num <= 0 then []
	elif num = 1 then [0]
	elif num = 2 then [0; 1]
	else
		let prev = fibonacci (num - 1)
		prev @ [prev[num - 2] + prev[num - 3]]
		
fibonacci 8 |> printfn "%A"
```

- define a recursive function that takes two integers as parameters and returns their greatest common divisor
```fsharp
let rec gcd (x: int) (y: int): int =
	if y = 0 then x
	else gcd y (x % y)

gcd 12 4 |> printfn "%A"
```