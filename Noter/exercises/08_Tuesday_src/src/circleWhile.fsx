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
    let mutable pair = (0.0, dAngle)
    let mutable tree = emptyTree
    while (snd pair) <= 2.0*Math.PI do
        tree <- onto tree (line center pair)
        pair <- (snd pair, dAngle + snd pair)
    make tree

// Render Sierpinski's triangle
render "Circle" width width picture
