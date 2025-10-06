let rec count_ones (s: string) =
    if s = "" then
        0
    else 
        let first = s.[0]
        let rest = s.[1..]
        (if first = '1' then 1 else 0) + count_ones rest

let input = System.Console.ReadLine()

printfn "%d" (count_ones input)