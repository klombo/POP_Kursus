(* 
let rec extractString (tuplelist: (string * int) list) : int list =
    match tuplelist with
    | [] -> []
    | head::tail -> snd head :: extractString tail

let listOfTuples = [("hej", 1); ("hello", 2); ("goddav", 4)]
printfn "%A" (extractString listOfTuples) 
*)


(* Define a functoin that takes as input a list of list of integers 
and return a list oncatinning all the integers in the input
let rec extractListOfInts (listOfInts: int list list) : int list =
    match listOfInts with
    | [] -> []
    | head::tail -> head @ extractListOfInts tail

let Ints = [[41; 1]; [40; 2]; [38; 4]]
printfn "%A" (extractListOfInts Ints)
*)


// Define a function that takes as input a list of string and
// returns the contatenation of these strings
(*
let ConcanateString (listofString : string list) : string =
    String.concat " " listofString
*)

let rec ConcanateString (listOfStrings : string list) : string =
    match listOfStrings with
    | [] -> ""
    | head::tail -> head + ConcanateString tail

let listOfStrings : string list = ["Hej "; "med "; "dig."]
printfn "%A" (ConcanateString(listOfStrings))
