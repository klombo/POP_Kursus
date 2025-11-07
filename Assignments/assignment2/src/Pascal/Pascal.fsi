module Pascal

type IntOrNaN =
    | Value of int
    | Error of string

// This function uses recursion to calculate the value of the position (n, k) in Pascal's triangle.
// Returns the position's Value int if the inputs are valid and Error Invalid Input if k > n || n < 0 || k < 0 || n > 10000.
// The function returns Error Overflow if value of the position (n, k) is bigger than Int32 Max Value
val pascal : (int * int) -> IntOrNaN

// This function calculates the value of the position (n, k) in Pascal's triangle without using recursion.
// Returns the position's Value int if the inputs are valid and Error Invalid Input if k > n || n < 0 || k < 0 || n > 100000.
// If value of the position (n, k) is bigger than Int32 Max Value the function returns Error Overflow 
val pascalNoRec : (int * int) -> IntOrNaN
