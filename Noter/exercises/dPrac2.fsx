(* Funktion der printer "Hello World" når argument er sand
let f (x: bool) =
    if x = true then printfn("Hello World")

f (false) *)

(* Funktioner de printer "Hello World" når argument er højere end 5
let f (x: int) =
    if x > 5 then printfn("Hello World")

f(10) *)

(* Funktioner der printer Hello World når parameteret ikke er nul
let f (x: int) =
    if not(x=0) then printfn("Hello World")

f(-1) *)

(* Funktioner der printer Hello World vis begge argumenter er false 
let f (x: bool, y: bool) =
    if x = false && y = false then printfn("Hello World")

f(false, false) *)

(* Funtkionen f tilføjer to ints og funktion g bruger funktionen f til at finde summen af
de to argumenter, men den mister decimaler når man konertere
let f (x: int, y: int) =
    let a = x + y
    printfn "%d" a
    a

let g(a: float, b: float) =
    let sum = f(int a, int b) 
    printfn "%f" (float sum)

g(2.1, 3.0) *)

