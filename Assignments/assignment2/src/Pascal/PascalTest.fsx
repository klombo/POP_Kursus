#load "Pascal.fs"
#load "Pascal.fsi"
open Pascal

let test (condition: bool): string =
    if condition then "[PASSED]"
    else "[FAILED]"

// Property 1 Testing
let hasPropertyOne ((n,k) : int * int) : bool =
    if (k = 0 || k = n) then
        pascal (n,k) = Value 1
    else false

let hasPropertyOneNoRec ((n,k) : int * int) : bool =
    if (k = 0 || k = n) then
        pascalNoRec (n,k) = Value 1
    else false

// Property 2 Testing
let hasPropertyTwo ((n,k) : int * int) : bool =
    if (n > k && k > 0) then
        pascal(n,k) = match pascal (n-1, k-1),  pascal (n-1,k) with
                        | Value x, Value y -> Value (x + y)
                        | _, Error e -> Error e
                        | Error e,_ -> Error e
    else false

let hasPropertyTwoNoRec ((n,k) : int * int) : bool =
    if (n > k && k > 0) then
        pascalNoRec(n,k) = match pascalNoRec (n-1, k-1),  pascal (n-1,k) with
                            | Value x, Value y -> Value (x + y)
                            | _, Error e -> Error e
                            | Error e,_ -> Error e
    else false

// Testing Inputs outside of Triangle
let inputInvalid ((n,k) : int * int) : bool =
    if (n < 0 || k<0 || k>n) then
        pascal (n,k) = Error "Invalid Input"
    else false

let inputInvalidNoRec ((n,k): int * int) : bool =
    if (n < 0 || k<0 || k>n) then
        pascalNoRec (n,k) = Error "Invalid Input"
    else false

// Testing Property 1
printfn "\n !!! Testing Property 1 !!!"
let propertyOneTestValues = [ (0,0); (6,0); (6,6); (10000,10000); (10000,0)]
for pair in propertyOneTestValues do
    printfn "Property 1 Test for pascal with (n, k): %A = %s" (pair) (test (hasPropertyOne pair))
    printfn "Property 1 Test for pascalNoRec with (n, k): %A = %s" (pair) (test (hasPropertyOneNoRec pair))

// Testing Property 2
printfn "\n !!! Testing Property 2 !!!"
let propertyTwoTestValues = [ (5,2); (34,17); (1000,999) ]
for pair in propertyTwoTestValues do
    printfn "Property 2 Test for pascal with (n, k): %A = %s" (pair) (test (hasPropertyTwo pair))
    printfn "Property 2 Test for pascalNoRec with (n, k): %A = %s" (pair) (test (hasPropertyTwoNoRec pair))

// Testing for cases outside pascals Triangle
printfn "\n !!! Testing Invalid Input !!!"
let invalidTestValues = [(-1, 0); (3, -1); (3,5); (100,-1000000); (-10000,-10000); (10000,1000000)]
for pair in invalidTestValues do
    printfn "Test that Inputs out of Triangle return Error Invalid Input for pascal with (n, k): %A = %s" (pair) (test (inputInvalid pair))
    printfn "Test that Inputs out of Triangle return Error Invalid Input for pascalNoRec with (n, k): %A = %s" (pair) (test (inputInvalidNoRec pair))