module Pascal 

let rec pascal ((n, k) : int * int) : int =
    match (n, k) with
    | (_, 0) -> 1
    | (n, k) when n = k -> 1
    | (n, k) when k > n -> 0
    | (n, k) -> pascal (n-1, k-1) + pascal (n-1,k)

let pascalNoRec ((n, k) : int * int) : int =
    if n <= 0 || k < 0 || k > n then 0
    else // Pascals triangle is initilazed at zero therefore it is n + 
        let mutable triangle = Array.init (n+1) (fun index -> Array.create (index+1) 0)
        for row in 0..n do
            for column in 0..row do
                if column = 0 || column = row then 
                    triangle.[row].[column] <- 1
                else
                    triangle.[row].[column] <- triangle.[row-1].[column-1] + triangle.[row-1].[column]
    
        triangle.[n].[k]
    
            