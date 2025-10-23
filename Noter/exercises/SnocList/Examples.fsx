#load "SnocList.fs"
open SnocLists.SnocList

let list1 : int SnocList = Snoc(Snoc(Snoc(Nil, 1), 2), 3)
let list2 : int SnocList = Snoc(Snoc(Snoc(Snoc(Nil, 7), 6), 5), 4)

printfn "Length of list1 = %A" (length list1)
printfn "Length of list2 = %A" (length list2)

printfn "Appended list = %A" (append list1 list2)