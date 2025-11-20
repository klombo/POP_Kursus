type car(kml: float, gas: float) =
    let mutable _gas = gas
    let _kml = kml

    member this.addGas (l: float) = _gas <- _gas + l

    member this.gasLeft = _gas

    member this.drive (d: float) = _gas <- _gas - (d/kml)

type customer(navn: string,adresse: string, tlfnr: int, kundeNr: int, mailListe: bool) =
    let mutable _navn = navn
    let mutable _adresse = adresse
    let mutable _tlfnr = tlfnr
    let _kundeNr = kundeNr
    let mutable _mailListe = mailListe

    member this.navn 
        with get() = _navn
        and set navn = _navn <- navn

    member this.adresse
        with get () = _adresse
        and set adresse = _adresse <- adresse

    member this.tlfnr
        with get() = _tlfnr
        and set tlfnr = _tlfnr <- tlfnr
    
    member this.mailListe
        with get() = _mailListe
        and set mailListe = _mailListe <- mailListe

    member this.getKundeNr = _kundeNr 

let kunde1 = customer("McLovin", "892 Momona St", 5552368, 1, false)
printfn "%A" (kunde1.navn)