module Pascal

type IntOrNaN =
    | Value of int
    | NaN

// This function uses recursion to calculate the value of the position (n, k) in Pascal's triangle.
// Returns the position's Value int if the inputs are valid and NaN if k > n, n < 0, k < 0 or n > 33.
// Always returns Value 1 for the edges, k = 0 or k = n, no matter how large n is.
val pascal : (int * int) -> IntOrNaN

// This function calculates the value of the position (n, k) in Pascal's triangle without using recursion.
// Returns the position's Value int if the inputs are valid and NaN if k > n, n < 0, k < 0 or n > 33.
// Always returns Value 1 for the edges, k = 0 or k = n, no matter how large n is.
val pascalNoRec : (int * int) -> IntOrNaN
