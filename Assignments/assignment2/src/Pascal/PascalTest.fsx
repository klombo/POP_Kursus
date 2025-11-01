#load "Pascal.fs"
#load "Pascal.fsi"
open Pascal

let test (condition: bool): string =
    if condition then "[PASSED]"
    else "[FAILED]"

// Property 1 Testing
let hasPropertyOne ((n,k) : int * int) : bool =
    if (k = 0 || k = n) then
        pascal (n,k) = 1
    else false

let hasPropertyOneNoRec ((n,k) : int * int) : bool =
    if (k = 0 || k = n) then
        pascalNoRec (n,k) = 1
    else false

// Property 2 Testing
let hasPropertyTwo ((n,k) : int * int) : bool =
    if (n > k && k > 0) then
        pascal(n,k) = pascal(n-1, k-1) + pascal(n-1,k)
    else false

let hasPropertyTwoNoRec ((n,k) : int * int) : bool = 
    if (n > k && k > 0) then
        pascalNoRec(n,k) = pascalNoRec(n-1,k-1) + pascalNoRec(n-1,k)
    else false

// Testing Inputs outside of Triangle
let inputOutOfTriangle ((n,k) : int * int) : bool =
    if (n < 0 || k<0 || k>n) then
        pascal (n,k) = 0
    else false

let inputOutOfTriangleNoRec ((n,k): int * int) : bool =
    if (n < 0 || k<0 || k>n) then
        pascalNoRec (n,k) = 0
    else false


// Testing Property 1
printfn "!!! Testing Property 1 !!!"
let propertyOneTestValues = [ (0,0); (6,0); (6,6) ]
for pair in propertyOneTestValues do
    printfn "Property 1 Test for pascal with (n, k): %A = %s" (pair) (test (hasPropertyOne pair))
    printfn "Property 1 Test for pascalNoRec with (n, k): %A = %s" (pair) (test (hasPropertyOneNoRec pair))

// Testing Property 2
printfn "!!! Testing Property 2 !!!"
let propertyTwoTestValues = [ (5,2); (6,3); (2,1) ]
for pair in propertyTwoTestValues do
    printfn "Property 2 Test for pascal with (n, k): %A = %s" (pair) (test (hasPropertyTwo pair))
    printfn "Property 2 Test for pascalNoRec with (n, k): %A = %s" (pair) (test (hasPropertyTwoNoRec pair))

// Testing for cases outside pascals Triangle
printfn "!!! Testing cases outside pascals Triangle !!!"
let invalidTestValues = [ (-1, 0); (3, -1); (3,5)]
for pair in invalidTestValues do
    printfn "Test that Inputs out of Triangle return 0 for pascal with (n, k): %A = %s" (pair) (test (inputOutOfTriangle pair))
    printfn "Test that Inputs out of Triangle return 0 for pascalNoRec with (n, k): %A = %s" (pair) (test (inputOutOfTriangleNoRec pair))

let mutable foundMax = false
let mutable i = 1

while foundMax = false do
    let result = pascal(i, i/2)
    if result <= 0 then
        printfn "The max n is %A" (i-1)
        foundMax <- true 
    else 
        printfn "pascal for (n,k) %A = %A" (i, i/2) (result)
        i <- i + 1