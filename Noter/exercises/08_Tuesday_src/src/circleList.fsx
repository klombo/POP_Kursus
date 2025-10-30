#r "nuget:DIKU.Canvas"
open Canvas
open Color
open System

let width = 400
let r = 100.0
let cx,cy = (200.0,200.0)
let dAngle = 0.1

let angles = [0.0..dAngle..2.0*Math.PI]@[2.0*Math.PI]
let coords = List.map (fun t -> (cx+r*cos t,cy+r*sin t)) angles
let tree = piecewiseAffine yellow 1.0 coords
let picture = make tree

render "Circle" width width picture
