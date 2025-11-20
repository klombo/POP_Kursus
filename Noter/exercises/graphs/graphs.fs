module Graphs

type Vertex = uint
type Edge = Vertex * Vertex

type Graph = 
    | EmptyGraph
    | Graph of Set<Vertex> * Set<Edge>

let insertVertex (g: Graph) (v: Vertex) : Graph =
    match g with
    | EmptyGraph -> Graph(Set.empty.Add(v), Set.empty<Edge>)
    | Graph(vList : Set<Vertex>, setE : Set<Edge>) -> Graph(vList.Add(v), setE)

let deleteVertex (g: Graph) (v: Vertex) : Graph =
    match g with
    | EmptyGraph -> g
    | Graph(vList : Set<Vertex>, setE : Set<Edge>) -> Graph(vList.Remove(v), setE)

    
let insertEdge (g: Graph) (e: Edge) : Graph =
    match g with
    | EmptyGraph -> Graph(Set.empty<Vertex>, Set.empty.Add(e))
    | Graph(vList : Set<Vertex>, setE : Set<Edge>) -> Graph(vList, setE.Add(e))

let deleteEdge (g: Graph) (e: Edge) : Graph =
    match g with
    | EmptyGraph -> g
    | Graph(vList : Set<Vertex>, setE : Set<Edge>) -> Graph(vList, setE.Remove(e))

// let edgeExists (g: Graph) (e: Edge) : bool =
//     match g with
//     | EmptyGraph -> false
//     | Graph()