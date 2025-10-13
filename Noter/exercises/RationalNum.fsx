let qplus (a : int, b: int) (c: int, d: int) : (int * int) =
    ((a*d + b*c), b*d)

let qminus (a : int, b: int) (c: int, d: int) : (int * int) =
    ((a*d-b*c), b*d)

let qmul (a : int, b: int) (c: int, d: int) : (int * int) =
    (a*c, b*d)

let qdiv (a : int, b: int) (c: int, d: int) : (int * int) =
    (a*d, b*c)

let toString (a: int, b: int) : string =
    string a + "/" + string b


//illustration
printfn "3/4 - (3/2 * 1/2) = %s" (toString (qminus (3,4) (qmul(3,2) (1,2))))