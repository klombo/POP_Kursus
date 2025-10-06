// 1a. What is the base case in this recursive function? What is the recursion?
// The base case is when the array is empty

// 1b. What happens when the target is out of range (i.e., smaller than the smallest value in the array or larger than the largest value)?
// Can this case be handled better? If yes, how?
// This case is handled because the array simply ends up being empty and that gives false.
// This could be handled better by simply checking if the number is bigger than or smaller than, the start or end of the list, since the list is sorted.

let rec binary_search (target: int) (a: int array): bool =
    if Array.isEmpty a then false
    else
        let mid = a.Length / 2
        if a.[mid] = target then
            true
        elif a.[mid] < target then
            binary_search target a.[(mid+1)..]
        else
            binary_search target a.[..(mid-1)]

let a = [|1;3;4;7;10;11;13;17;18|]

// binary_search 0 a |> printfn "%A" 

let nonRecursiveBinarySeach (target: int) (a: int array): bool =
    let mutable found = false
    let mutable right = a.Length - 1
    let mutable left = 0
    while left <= right && not found do
        let mid = (left + right) / 2
        if a.[mid] = target then
            found <- true
        elif a.[mid] < target then
            left <- mid + 1
        else
            right <- mid - 1

    found

nonRecursiveBinarySeach 17 a |> printfn "%A" 
nonRecursiveBinarySeach 5 a |> printfn "%A" 
