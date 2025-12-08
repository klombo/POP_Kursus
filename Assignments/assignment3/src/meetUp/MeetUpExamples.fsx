#load "MeetUp.fs"
#load "MeetUp.fsi"

open MeetUp

let exampleList: Participant list = [
    Normal("David Attenborough", 0.00, 0.98, 0.61);
    CopyCat("Linda Hamilton",0.36, 0.44, 0.25);
    Skeptic("Jesus Christus", 0.25, 0.72, 0.82);
    Normal("Thomas Tog", 0.15, 0.65, 0.09);
    CopyCat("Jessica Rabbit", 0.52, 0.14, 0.15);
    Normal("Christopher Columbus", 0.65, 0.55, 0.42);
    Skeptic("Elizabeth Turner", 0.45, 0.35, 0.57);
    Normal("Dan Turrell", 0.78, 0.81, 0.78);
    Normal("Queen Elizabeth", 0.92, 0.52, 0.51);
    Skeptic("Charlie Kirk", 1.0, 0.09, 1.0)
]


let SimulationWithNoVisual (listOfParticipants: Participant List) =

    let getAveragePoliticalView (politicalViews: Participant List): float = 
        politicalViews 
        |> List.map (fun person -> match person with
                                                | person -> person.politicalView)
        |> List.average

    let printPoliticalView (participantList: Participant List) : unit = 
        participantList |> List.iter (fun person -> printfn "%s's political view is: %A" person.name person.politicalView)
        printfn "Average politicalView: %A \n" (getAveragePoliticalView listOfParticipants)

    printPoliticalView listOfParticipants

    for i in 1..10000 do
        simulateMeeting listOfParticipants |> ignore

    printPoliticalView listOfParticipants

SimulationWithNoVisual exampleList
runSimulation exampleList (700,700) (Some 250)
