// DIKU-Canvas interact sketch
let rec interact title width height delayTime draw react prevState =
    let ev = getEvent ()
    let newState = react prevState ev
    match newState with
        Some s -> 
            draw s
            interact title width height delayTime draw react s
        _ -> 
            interact title width height delayTime draw react prevState
