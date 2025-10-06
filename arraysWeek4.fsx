// let array = [|"a"; "b"; "c"; "d" |]

// let array = [|1.1; 1.2; 1.3; 1.4|]

// let array : int array = Array.zeroCreate(20)

// let array : float array = Array.zeroCreate(10)

// let array : string array = Array.zeroCreate(30)

// let array = [|0 .. 19|]

// let array : int array = Array.init 20 (fun index -> index * index)

// let array = [|0 .. 20|]
// array[0] <- 42

// let array : string array = Array.init 20 (fun index -> (string (index)))

// printfn "%A" (array)

let array = [|0 .. 19|]

// printfn "%A" (array.[9])

// printfn "%A" (array.[0])

// printfn "%A" (array.Length)

// let slicedArray = array[5..15]
// printfn "%A" (slicedArray)

// let slicedArray = array[15..]
// printfn "%A" (slicedArray)

// let slicedArray = array[..5]
// printfn "%A" (slicedArray)

array.[0] <- 42
printfn "%A" (array)