#r "nuget:Diku.Canvas"
open Canvas
open Color

let width,height = 600,400

let p0 = (350.0, 200.0)
let p1 = (350.0, 150.0)

let line = piecewiseAffine yellow 1.0 [p0; p1]

let circle = ellipse yellow 1.0 5.0 5.0

let picture =
    let mutable tree = alignH(alignV (line) Center (circle)) Center emptyTree
    make tree

render "PrimitiveTree af en pil fra koordinaterne p0 til p1" width height picture