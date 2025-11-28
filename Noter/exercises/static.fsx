type student(navn: string) =
    static let mutable _nextId = 0u
    let _id = _nextId
    do _nextId <- _nextId + 1u
    let mutable _navn = navn
    
    static member nextId = _nextId
    member this.navn = _navn
    member this.id = _id

printfn "nextId: %A" student.nextId
let elev1 = student("Vilfresh")
printfn "navn: %s id: %d" elev1.navn elev1.id
printfn "nextId: %A" student.nextId
let elev2 = student("Klement")
printfn "navn: %s id: %d" elev2.navn elev2.id



