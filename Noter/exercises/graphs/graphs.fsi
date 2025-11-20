module Graphs

type Vertex = uint
type Edge = Vertex * Vertex

type Graph = 
    | EmptyGraph
    | Graph of Set<Vertex> * Set<Edge>

// insert a vertex in a Graph and return the updated Graph. If the vertex already exists, then nothing changes.
val insertVertex: Graph -> Vertex -> Graph 

// delete a vertex and the edges connected to it, if it exists. Otherwise nothing changes.
val deleteVertex: Graph -> Vertex -> Graph 

// insert an edge between two vertices. If the edge already exists, then nothing changes.
val insertEdge: Graph -> Vertex -> Vertex -> Graph 

// delete an edge between two vertices. If the edge already exists, then nothing changes.
val deleteEdge: Graph -> Vertex -> Vertex -> Graph

// true if edge exists
val edgeExists: Graph -> Vertex -> Vertex -> bool 

// return the number of edges connected a specified Vertex wrapped as an Option type. Return None if the Vertex does not exist
val degree: Graph -> Vertex -> uint option 

// Writes the vertices and edges to the screen
val print: Graph -> unit 

// returns true if every vertex is connected to every other vertex
val isFullyConnected: Graph -> bool 