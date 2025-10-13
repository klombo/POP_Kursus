# Worksheet_W2
#### Exercises:
#### 1. Diamond shape
The `.fsx` file is  [`diamondShape.fsx`](exercises/diamondShape.fsx)

Topics: #functions/recursion 

Given a number n, write a program to print a diamond shape with 2n rows.

Example: print_diamond 5
![[Pasted image 20251013160106.png]]

``` fsharp
let rec spaces n =
	if n <= 0 then ""
	else " " + spaces (n-1)
```

1. What is the name of this function? What is the type of its input and output? Write a specification for this function (explaining what it does).
	- The function is called spaces
	- Its input is an n and its output i a string
	- The function first checks if n is less than or equal to 0, if it is it returns "". That is the base case
	- The recursion of this function adds " " and then calls spaces with (n - 1) 

```fsharp
let rec diamond_top l n =
	if (l = 0) then []
	else
		(diamond_top (l-1) n)@((spaces (n-l) + stars l)::[])
```
- The base case of this function is returning an empty list when `l = 0`.
- The recursive part we call the diamond_top function with l-1 and concatenates the return of spaces for `n-l`.

- Create a new recursive function that takes as input an integer n (target number of rows) and an integer l (the number of iterations) and returns a list of strings that represnt the rows of the bottom of a diamond shape pattern
```fsharp
let rec diamond_bot l n =
    if (l = 0) then []
    else
        ((spaces (n-l) + stars l)::[])@(diamond_bot (l- 1) n)

let rec print_list (l: string list) : unit =
    if (l = []) then printfn ""
    else
        printfn "%s" l.Head
        print_list l.Tail
```

- For fun i created a way to choose a number in the command prompt.
``` fsharp
printfn "VÆLG EN LILLE STØRRELSE (TAK) "

let input = System.Console.ReadLine()
let size = int input
let diamond = (diamond_top size size) @ (diamond_bot (size-1) size)
print_list diamond
```
