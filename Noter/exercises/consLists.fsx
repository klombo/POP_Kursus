type 'a ConsList = Nil | Cons of 'a * ' a ConsList

let fold nil cons = 
    let rec f xs = match xs with
                   Nil -> nil
                 | Cons (x, xs') -> cons x (f xs')
            
let toList (xs: 'a ConsList) = fold[] (fun x xs -> x :: xs) xs

printfn "%A" (toList (Cons (0, Cons (0, Cons (0, Nil)))))