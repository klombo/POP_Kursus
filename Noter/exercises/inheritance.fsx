type person (name: string, adresse: string, tlfNr: int) = 
    let mutable _name = name
    let mutable _adresse = adresse
    let mutable _tlfNr = tlfNr

    member this.name = _name
    member this.adresse = _adresse
    member this.tlfNr = _tlfNr


type customer (name: string, adresse: string, tlfNr: int, kundeNr: int, mailliste: bool) =
    inherit person(name, adresse, tlfNr)
    let mutable _kundeNr = kundeNr
    let mutable _mailliste = mailliste

let c1 = customer("Klemensker", "Hesseløgade 51 4th", 51865654, 01, false)

printfn "customer %s" c1.name