module Vector

type Vector = float * float

let vectorLength ((x, y): Vector) : float =
    sqrt (x * x + y * y)

let vectorAddition ((x, y): Vector) ((a,b): Vector) : Vector =
    Vector (x + a, y + b)

let vectorScaling ((x, y): Vector) (a: float) : Vector =
    Vector (x * a, y * a)