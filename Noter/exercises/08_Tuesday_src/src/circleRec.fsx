#r "nuget:DIKU.Canvas"
open Canvas
open Color
open System

let width = 400
let radius = 100.0
let center = (200.0,200.0)
let dAngle = 0.1

let pointPolar (x1,x2) (r,t) =
    (x1+r*cos t,x2+r*sin t)

let line center (a1,a2) =
    let p0 = pointPolar center (radius, a1)
    let p1 = pointPolar center (radius, a2)
    piecewiseAffine yellow 1.0 [p0; p1]

let picture = 
    let rec makeCircle pair =
        if (snd pair) <= 2.0*Math.PI then
            let nextPair = (snd pair, dAngle + snd pair)
            onto (line center pair) (makeCircle nextPair)
        else
            let finalPair = (fst pair, 2.0*Math.PI)
            line center finalPair
    makeCircle (0.0, dAngle) |> make

render "Circle" width width picture
