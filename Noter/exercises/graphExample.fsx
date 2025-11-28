#r "nuget: DIKU.Graph, 1.0.0"
open simpleGraph

let g : Graph<int> =
    empty
    |> addEdge 1 2
    |> addEdge 1 4
    |> addEdge 2 4
    |> addVertex 3

printfn "Graph: %A" g

let v = vertices g
printfn "Vertices: %A" v

let e = edges g
printfn "Edges: %A" e

let conComp = connectedComponents g
printfn "Connected Components: %A" conComp