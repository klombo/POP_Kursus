# Deliberate_Practice_W1 2-9-25

### Topics: 
#functions/declaration #types/declaration
#### Tasks:
The `.fsx` doesn't exist
- Define a function that takes as parameter the radius of a circle and returns its area
``` fsharp
let areaCirc (radius: float): float =
	let area = radius * radius * 3.1415
	area
```
- Define a function that takes as parameter the radius of a circle and returns the length of its perimeter
``` fsharp
let circumferenceCirc (radius: float): float =
	let circumference = 2.0 * radius * 3.1415
	circumference
```
- Define a function that takes as parameter the length of the side of a square and returns its area
``` fsharp
let areaSquare (sideLength: float): float =
	let area = sideLength * sideLength
	area
```
- Define a function that takes as parameter the length of the side of a square and returns its perimeter
``` fsharp
let circumferenceSquare (sideLength: float): float =
	circumference = sideLength * 4
	circumference
```