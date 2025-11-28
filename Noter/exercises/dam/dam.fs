type board() =
    let height = 8
    let width = 8
    let squares = Array2D.init height width (fun i j -> None)
    member this.tile(x: int, y: int) = 
        let result = squares[x,y]
        result
    

    

type piece(color : string) =
    let color = color
    member this.maxMoves() =
        printfn "s"

type ordinary(color: string) =
    inherit piece(color)

type king(color: string) =
    inherit piece(color)