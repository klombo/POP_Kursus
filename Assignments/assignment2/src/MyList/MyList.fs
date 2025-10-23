module MyList

type 'a MyList = Empty | Something of 'a * 'a MyList

let rec take (n: int) (inputList : 'a MyList): 'a MyList =
    match n, inputList with
    | n, _ when n <= 0 -> Empty
    | _, Empty -> Empty
    | n, Something (head, tail) -> Something(head, take (n-1) tail)

let rec drop (n: int) (inputList : 'a MyList): 'a MyList =
    match n, inputList with
    | n, _ when n <= 0 -> inputList
    | _, Empty -> Empty
    | n, Something (head, tail) -> drop (n-1) tail

let rec length (inputList : 'a MyList): int =
    match inputList with
        | Empty -> 0
        | Something(head, tail) -> 1 + length tail

let rec map (appliedFunc: 'a -> 'b) (inputList : 'a MyList): 'b MyList =
    match inputList with
    | Empty -> Empty
    | Something(head, tail) -> Something(appliedFunc head, map appliedFunc tail)