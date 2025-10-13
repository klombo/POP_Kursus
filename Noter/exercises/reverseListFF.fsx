let rec rev (xs: 'T List): 'T List =
    match xs with
    | xs::xn -> rev xn @ [xs]
    | [] -> []

let l = [[1;2;3;4;5;6;7;8;9;10]]
rev l |> printfn "%A"