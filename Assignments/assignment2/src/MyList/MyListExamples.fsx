#load "MyList.fs"
open MyList

let list1 = Something(1, Something(2, Something(3, Something(4, Something(5, Empty)))))
let list2 = Something("morgen", Something("dag", Something("aften",  Empty)))
let list3 = Empty


// take examples
printfn "take 2 list1 = %A" (take 2 list1)
printfn "take 10 list2 = %A" (take 10 list2)
printfn "take 3 Empty = %A" (take 3 list3)

// drop examples
printfn "drop 2 list1 = %A" (drop 2 list1)
printfn "drop 10 list1 = %A" (drop 10 list2)
printfn "drop 1 Empty = %A" (drop 1 list3)

// length examples
printfn "length list1 = %A" (length list1)
printfn "length list2 = %A" (length list2)
printfn "length Empty = %A" (length list3)

// map examples
printfn "map (fun x -> x * 10) list1 = %A" (map (fun x -> x * 10) list1)
printfn "map (fun x -> god + x) list2 = %A" (map (fun x -> "god" + x) list2)
printfn "map (fun x -> x + 1) Empty = %A" (map (fun x -> x + 1) list3)