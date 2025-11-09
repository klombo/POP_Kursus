#r "nuget:DIKU.Canvas, 2.0"
open Canvas
open Color

type state = int*int // state is a color
let rectWidth, rectHeight = 40, 40
let width,height = 600,600 // window size

let step: int = 25

/// Prepare a Picture by the present state whenever needed
let draw ((x: int, y: int): state): Picture =
    filledRectangle blue rectWidth rectHeight
    |> translate x y
    |> make

/// React to whenever an event happens
/// All but left-, right-, up-, and down-arrows are ignored. Each of these move the square by step
/// Present state is ignored.
let react ((x: int, y: int): state) (ev:Event) : state option =
    match ev with
        | LeftArrow ->
            printfn "Going Left!"
            Some (x - step, y)
        | RightArrow ->
            printfn "Going Right!"
            Some (x + step, y)
        | DownArrow ->
            printfn "Going Down!"
            Some (x, y + step)
        | UpArrow->
            printfn "Going Up!"
            Some (x, y - step)
        | _ -> None // ignore event, state is not updated

// Start interaction session
let initialState = (width/2, height/2) // First state drawn by draw
let delayTime = None // no delay time
interact "ColorTest" width height delayTime draw react initialState
