let rec spaces n =
    if n <= 0 then ""
    else " " + spaces (n-1)

// What is the name of this function? 
// - spaces
// What is the type of its inputs and output?
// - inputs are ints and outputs is string

let rec stars n =
    if n <= 0 then ""
    else " " + ("*") + stars(n-1)

// Funktionen stars skriver en * for n ud i en linje indtil n er ligmed 0

let rec diamond_top l n =
    if (l = 0) then []
    else
        (diamond_top (l- 1) n)@((spaces (n-l) + stars l)::[])


// row 0: nothing
// row 1: 4 spaces, 1 "*" pattern
//     *
// row 2: 3 spaces, 2 "*" pattern
//    **
// row 3: 2 spaces, 3 "*" pattern
//   ***
// row 4: 1 space, 4 "*" pattern
//  ****
// row 5: 0 space, 5 "*" pattern
// ***** 

// You should explain the base case and the recursion for this function
//
// The base case of the diamond_top function is:
// if(1 = 0) then []
// og recursive call er linjen
// (diamond_top (l-1) n)@((spaces (n-1) + stars l)::[])

// n repræsenterer row number

// Starting from the end of diamond top
// row 5: 0 space, 5 "*" pattern
// *****
// row 4: 1 space, 4 "*" pattern
//  ****
// row 3: 2 spaces, 3 "*" pattern
//   ***
// row 2: 3 spaces, 2 "*" pattern
//    **
// row 1: 4 spaces, 1 "*" pattern
//     *
// row 0 nothing

let rec diamond_bot l n =
    if (l = 0) then []
    else
        ((spaces (n-l) + stars l)::[])@(diamond_bot (l- 1) n)

let rec print_list (l: string list) : unit =
    if (l = []) then printfn ""
    else
        printfn "%s" l.Head
        print_list l.Tail


printf "VÆLG EN LILLE STØRRELSE (TAK) "

let input = System.Console.ReadLine()
let size = int input
let diamond = (diamond_top size size) @ (diamond_bot (size-1) size)
print_list diamond