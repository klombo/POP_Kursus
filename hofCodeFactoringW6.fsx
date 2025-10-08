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
    | x1::xn, [] -> (x1 + 0) :: zipAdd xn []
    | [], y1::yn -> (0 + y1) :: zipAdd [] yn
    | [], [] -> []

let rec zipWith (f : 'a -> 'b -> 'c) (xInputList : 'a list) (yInputList : 'a list) : 'c list =
    match xInputList, yInputList with
    | x1::xn, y1::yn -> f x1 y1 :: zipWith f xn yn
    | _ -> []

(*let rec printAll (f : 'a -> string) (inputList : 'a list): unit =
    match inputList with 
    | 
    |
    | [] -> []*)

let exampleList = [1; 0; -3; 15; 2; 3; 4; -5; 7]
let exampleList2 = [20; -4; 12; -2; 0; 11; 1; 3; -4; 9]

filterPos exampleList |> printfn "filterPos: %A"
addPos exampleList |> printfn "addPos: %A"
zipAdd exampleList exampleList2 |> printfn "zipAdd: %A"
zipWith (fun x y -> x * y) exampleList exampleList2 |> printfn "zipWith: %A"