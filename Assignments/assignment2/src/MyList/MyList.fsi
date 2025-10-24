module MyList

type 'a MyList = Empty | Something of 'a * 'a MyList


// Takes an integer, called n, and a generic type MyList, called inputList, and returns a MyList of the same type as inputList, with only the first n elements of the inputList.
// If n is larger than the number of elements in inputList return the original list.
// if n is smaller or equal to zero rerturn the inputList.
// If the inputList is empty return an empty MyList.
val take : int -> 'a MyList -> 'a MyList

// Takes an integer, called n, and a generic type MyList, called inputList, and returns a MyList, of the same type as inputList, with the first n elements of the inputList removed.
// If n is larger than the number of elements in inputList return an emptyList.
// If n is smaller or equal to zero return the inputList.
// If the inputList is empty return an empty MyList.
val drop : int -> 'a MyList -> 'a MyList

// Takes a generic type MyList, called inputList, and returns the length of inputList.
// If the inputList is empty it returns 0.
val length : 'a MyList -> int

// Takes a a function, called appliedFunc, and a generic type MyList, called inputList, and return a MyList, with the appliedFunc applied to each element.
// The appliedFunc input needs to of the same type as the elements of MyList.
// If the inputList is empty it returns an empty MyList.
val map : ('a -> 'b) -> 'a MyList -> 'b MyList