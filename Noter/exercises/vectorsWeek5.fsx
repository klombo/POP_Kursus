// I would make a Type called Vector which is (float * float)

type vector = float * float

//What names do you give to these three functions? Why?
//I would call one function vectorLength
//I would call one function vectorAddition
//I would call one function vectorScaling

//Write the specification of the three functions.

//The vectorLength specifiation needs to be able to:
//The squareroot of sum of the the two cords squared

//The vectorAddition specifiation needs to able to:
//Needs to take to take two vectors and find the sum of the first cords
//and the second cords and then return a new vector with those sums

//The vectorScaling specifiation needs to able to:
//This needs to take a vector and a number and return a vector with
//the new cords that is the product of the vector cords and the number.

//vectorLength (4,3) = sqrt(4^2 + 3^9) = sqrt(25) = 5

//vectorAddition (4,2) (6,7) = (4+6, 2+7) = (10,9)

//vectorScaling 2 (4,2) = (4*2, 2*2) = (8,4)

let vectorLength ((x, y): vector) =
    sqrt (x * x + y * y)

let vectorAddition ((x, y): vector) ((a,b): vector) =
    vector (x + a, y + b)

let vectorScaling ((x, y): vector) (a: float) =
    vector (x * a, y * a)

// I use the mathematical equations and use this as a base to build on

// This would simply add an extra coordinate in the tuple, it would be
// type vector3D = float * float * float
// these functions would then also need to take an extra coordinate.
