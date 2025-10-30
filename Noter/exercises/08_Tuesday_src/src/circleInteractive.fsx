#r "nuget:diku.canvas"
open Canvas
open Color

let width = 400
let r = 100.0
let cx,cy = (200.0,200.0)

type state = int
let draw (s:state) =
    let dAngle = 2.0 * System.Math.PI / (float n) 
    let angles = List.init (s+1) (fun i -> (float i) * dAngle)
    let coords = List.map (fun t -> (cx+r*cos t,cy+r*sin t)) angles
    piecewiseAffine yellow 1.0 coords |>  make

let react (s:state) (ev:Event) : state option =
  match ev with
    | LeftArrow | RightArrow -> printfn "%A" s
    | _ -> ()
  match ev with
    | LeftArrow -> Some (max 3 (s-1))
    | RightArrow -> Some (min 36 (s+1))
    | _ -> None

let initialState = 36
let delayTime = None // no delay time
interact "Polygonal approximation" width width delayTime draw react initialState
