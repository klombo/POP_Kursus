#r "nuget:DIKU.Canvas"
open Canvas
open Color

let w = 512 // base length of triangle, and smalles triangle to draw

let picture = 
    let length = float w
    let tree = filledPolygon blue [0.0,length; length,length; length/2.0,0.0; 0.0,length]
    make tree

render "Triangle" w w picture
