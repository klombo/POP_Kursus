let rec createPairs (students : int list) =
    match students with
    | first :: second :: tail -> (first,second) :: createPairs tail
    | _ -> []

let createLineList (students : int list) (lineNum : int) =
    List.filter (fun studentID -> studentID % 4 = lineNum) students;;

let studentList = [0..99]

createPairs studentList |> printfn "%A"


createLineList studentList 0 |> createPairs |> printfn "Line 0 Groups: %A"
createLineList studentList 1 |> createPairs |> printfn "Line 1 Groups: %A"
createLineList studentList 2 |> createPairs |> printfn "Line 2 Groups: %A"
createLineList studentList 3 |> createPairs |> printfn "Line 3 Groups: %A" 
