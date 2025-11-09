module Pascal

type IntOrError =
    | Value of int
    | Error of string

// This function uses recursion to calculate the value of the position (n, k) in Pascal's triangle.
// Returns the position's Value int if the inputs are valid. 
// The function returns Error Invalid Input if k > n || n < 0 || k < 0 || n > 10000.
// The function returns Error Overflow if value of the position (n, k) is bigger than Int32 Max Value
val pascal : (int * int) -> IntOrError

// This function calculates the value of the position (n, k) in Pascal's triangle without using recursion.
// Returns the position's Value int if the inputs are valid.
// If k > n || n < 0 || k < 0 || n > 100000, then the function returns Error Invalid Input.
// If value of the position (n, k) is bigger than Int32 Max Value the function returns Error Overflow.
val pascalNoRec : (int * int) -> IntOrError
