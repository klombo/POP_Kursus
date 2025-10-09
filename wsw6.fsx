let rec skeleton (operator: 'a -> 'b -> 'c) (baseCase : int) (xs: 'a list): int =
    match xs with
    | [] -> baseCase
    | head :: tail -> operator head (skeleton operator baseCase tail)

let prod (xs: 'T List) = skeleton (fun x acc -> x * acc) (1) (xs)
let length (xs: 'T list) = skeleton (fun _ acc -> 1 + acc) (0) (xs)


let example = [1;2;3;4;5;6]

prod [] |> printfn "%A"
length [] |> printfn "%A"

