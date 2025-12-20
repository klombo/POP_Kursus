#r "nuget:DIKU.Graph, 1.0.0"
#r "nuget:DIKU.Canvas"

#load "MeetUp.fs"

open MeetUp

let exampleList: Participant List = [
    Normal("David Attenborough", 0.00, 0.98, 0.61);
    CopyCat("Linda Hamilton",0.36, 0.44, 0.25);
    Skeptic("Jesus Christus", 0.25, 0.72, 0.82);
    Normal("Thomas Tog", 0.15, 0.65, 0.09);
    CopyCat("Jessica Rabbit", 0.52, 0.14, 0.15);
    Normal("Christopher Columbus", 0.65, 0.55, 0.42);
    Skeptic("Elizabeth Turner", 0.5, 0.35, 0.57);
    Normal("Dan Turrell", 0.78, 0.81, 0.78);
    Normal("Queen Elizabeth", 0.92, 0.52, 0.51);
    Skeptic("Charlie Kirk", 1.0, 0.09, 1.0)
]

let SimulationWithNoVisual (listOfParticipants: Participant List) (amountOfRounds:int) =
    printfn "\n"
    let getAveragePoliticalView (politicalViews: Participant List): float = 
        politicalViews 
        |> List.map (fun person -> match person with
                                                | person -> person.politicalView)
        |> List.average

    let printPoliticalView (participantList: Participant List) : unit = 
        participantList |> List.iter (fun person -> printfn "%s's political view is: %A" person.name person.politicalView)
        printfn "Average politicalView: %A \n" (getAveragePoliticalView listOfParticipants)

    printPoliticalView listOfParticipants

    for i in 1..amountOfRounds do
        simulateMeeting listOfParticipants |> ignore

    printPoliticalView listOfParticipants

let testTypes =
    let testList: Participant List = [
        Normal("Normal", 1.0, 0.2, 0.5)
        CopyCat ("CopyCat", 0.6, 0.2, 0.5)
        Skeptic ("Skeptic", 0.2,0.2,0.5)
    ]
    for i in 0..testList.Length-1 do
        for j in 0..testList.Length-1 do
            let isAMatch = testList[i].MatchScore (testList[j]) > 0.5
            testList[i].OnInteraction (testList[j]) isAMatch
            |> printfn "when %s with politicalView: %A, meets %s with politicalView: %A, then amount moved: %A." 
                testList[i].name testList[i].politicalView testList[j].name testList[j].politicalView 

testTypes
SimulationWithNoVisual exampleList 100
runSimulation exampleList



