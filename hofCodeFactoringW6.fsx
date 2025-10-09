let rec filterPos (inputList: int list):int list =
    match inputList with
    | head :: tail when head > 0 -> head :: filterPos tail 
    | head :: tail -> filterPos tail
    | [] -> []

let rec addPos (inputList: int list):int =
    match inputList with
    | head :: tail when head > 0 -> head + addPos tail 
    | head :: tail -> addPos tail
    | [] -> 0

let rec zipAdd (xInputList: int list) (yInputList: int list):int list = 
    match xInputList, yInputList with
    | x1::xn, y1::yn -> (x1+y1) :: zipAdd xn yn
    | x1::xn, [] -> x1 :: zipAdd xn []
    | [], y1::yn -> y1 :: zipAdd [] yn
    | [], [] -> []

let rec zipWith (f : 'a -> 'b -> 'c) (xInputList : 'a list) (yInputList : 'a list) : 'c list =
    match xInputList, yInputList with
    | x1::xn, y1::yn -> f x1 y1 :: zipWith f xn yn
    | x1::xn, [] -> x1 :: zipWith f xn [] // simply adds to the end of the list, doesn't run the function with it as a parameter
    | [], y1::yn -> y1 :: zipWith f [] yn // ---||---
    | _ -> []

let rec printAll (f : 'a -> string) (inputList : 'a list): unit =
    match inputList with 
    | head :: tail -> 
        printfn "%s" (f head) 
        printAll f tail
    | [] -> ()

type Number = 
    | I of int 
    | R of int * int 
    | F of float

let rec show (n: Number): string =
    match n with
    | (I n) -> string n
    | (R (a,b)) -> (string a) + "/" + (string b) 
    | (F n) -> string n

let rec showAll (n: Number list): string =
    match n with
    | nHead::nTail -> "["+ show nHead + "]" +  showAll nTail  
    | [] -> ""
    
let exampleList = [1; 0; -3; 15; 2; 3; 4; -5; 7]
let exampleList2 = [20; -4; 12; -2; 0; 11; 1; 3; -4; 9; 20]

let exampleNumberList = [(I 4); (F 2.5); (F 1.5); (R (1,5)); (I 9)]

filterPos exampleList |> printfn "filterPos: %A"
addPos exampleList |> printfn "addPos: %A"
zipAdd exampleList exampleList2 |> printfn "zipAdd: %A"
zipWith (fun x y -> x * y) exampleList exampleList2 |> printfn "zipWith: %A"
printAll (fun a -> string a) exampleList
show (I 4) |> printfn "show (I 4): %A"
show (R (3,4)) |> printfn "show (R (3,4)): %A"
show (F 2.5) |> printfn "show (F 2.5): %A"
showAll exampleNumberList |> printfn "showAll: %A"