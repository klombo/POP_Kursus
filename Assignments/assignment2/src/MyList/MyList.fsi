module MyList

type 'a MyList = Empty | Something of 'a * 'a MyList

val take : int -> 'a MyList -> 'a MyList

val drop : int -> 'a MyList -> 'a MyList

val length : 'a MyList -> int

val map : ('a -> 'b) -> 'a MyList -> 'b MyList