module Pascal


// Takes a pair of natural numbers n and k, and returns the corresponding binomial coefficient for n choose k
// If the pair is outside the triangle meaning n<k or n<0 or k<0 then we return 0
// pascal: int * int -> int
val pascal : (int * int) -> int

// Takes a pair of natural number n and k, and returns the corresponding binomial coefficient for n choose k
// If the pair is outside the triangle meaning n<k or n<0 or k<0 then we return 0
// pascalNoRec : int * int -> int
val pascalNoRec : (int * int) -> int
