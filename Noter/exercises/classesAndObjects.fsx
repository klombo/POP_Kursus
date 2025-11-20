type elev(navn: string) =
    let mutable _navn = navn

    member this.navn 
        with get() = _navn
        and set navn = _navn <- navn 

let E1 = elev("Klement Ottosen")
let E2 = elev("Nikolaj Nielsen")

printfn "%A" (E1.navn)   
E1.navn <- "Klement Bubby Ottosen"
printfn "%A" (E1.navn)
printfn "%A" (E2.navn)
