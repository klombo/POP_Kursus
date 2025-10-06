(*
let stringIsEmpty (s: string) : string option=
    if s = "" then None
    else Some s

stringIsEmpty("Hello World") |> printfn ("%A")
*)

(*
let divisionBy2 (x : int) : int option =
    if (x % 2 = 0) then Some (x/2)
    else None

divisionBy2(20) |> printfn ("%A")
divisionBy2(15) |> printfn ("%A")
*)

let isIntOption (i: int option) =
    if i = None then Some "no int Value"
    else None

isIntOption (Some 4) |> printfn ("%A")