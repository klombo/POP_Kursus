(* for x = 0 to 4 do
    printfn "%d" x *)

(* let array = Array.init 10 (fun index -> (string (index)))
for x = 0 to array.Length - 1 do
    printfn "%A" array[x] *)

let array = [|0..20|]
for x = 0 to array.Length - 1 do  
    let t = array[x]+1
    printfn "%A" t

let incrementArray
