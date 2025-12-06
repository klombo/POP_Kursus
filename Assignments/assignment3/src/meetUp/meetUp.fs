#r "nuget:DIKU.Canvas"
#r "nuget: DIKU.Graph, 1.0.0"
open simpleGraph
open Canvas
open Color

module MeetUp =

    [<AbstractClass>]
    type Participant (name: string, politicalview: float, influenciable: float, rizz: float) =
        // diff rizz, gør om de har mere inflydelse
        // This is a minimal implementation of Participant. You are welcome to
        // add your own fields, functions, properties and methods.

        // Replace _id code with your own for generating a unique unsigned
        // integer for each participant
        static let mutable _latestID = 0u // Make a static konstruktor
        do _latestID <- _latestID + 1u //have the class + 1, so that for every new participant, they get a unique id
        let _id = _latestID //
        let mutable _politicalview = politicalview
        let mutable _influenciable = influenciable
        let mutable _rizz = rizz

        interface System.IComparable with
            member this.CompareTo something =
                match something with
                | :? Participant as other -> this.Id.CompareTo other.Id
                | _ -> -1

        override this.GetHashCode() = this.Id.GetHashCode()
        override this.Equals(something) =
            match something with
            | :? Participant as other -> this.Id.Equals other.Id
            | _ -> false

        member this.Id = _id

        // Update such that PoliticalView and Influenciable are restricted to the 
        // interval [0,1].

        // 
        member this.influenciable 
            with get() = _influenciable
            and set(value) =
                if value < 0.0 then // if value smaller than 0.0, then we clamp it to 0.0
                    _influenciable <- 0.0
                elif value > 1.0 then 
                    _influenciable <- 1.0 //If value larger than 1.0 then we clamp it to be 1.0
                else 
                    _influenciable <- value

        member this.politicalView 
            with get() = _politicalview
            and set(value) =
                if value < 0.0 then
                    _politicalview <- 0.0
                elif value > 1.0 then 
                    _politicalview <- 1.0
                else 
                    _politicalview <- value


        member this.rizz
            with get() = _rizz
            and set(value) =
                if value < 0.0 then 
                    _rizz <- 0.0
                elif value > 1.0 then
                    _rizz <- 1.0
                else
                    _rizz <- value

        abstract member MatchScore: other: Participant -> float
        default this.MatchScore other = 
            let diff = this.politicalView-other.politicalView
            1.0 - (System.Math.Abs diff)

            
        abstract member OnInteraction: other:Participant -> isAMatch:bool -> float
        default this.OnInteraction other isAMatch = 
            let difference = other.politicalView-this.politicalView  
            let influenceStrength = this.influenciable* other.rizz
            if isAMatch then
                difference * influenceStrength // Moves towards the other person (Positiv)
            else 
                difference * influenceStrength * (-1.0) // political view moves away from eachother

    //////////////////////////////////////////////////////////////////////////

    // Normal person, bevæger sig normalt
    type Normal(name: string, politicalview: float, influenciable: float, rizz: float) =
        inherit Participant(name, politicalview, influenciable, rizz)


    // Copycat person, bliver bare det samme som den person de møder.
    type CopyCat(name: string, politicalview: float, influenciable: float, rizz: float) =
        inherit Participant(name, politicalview, influenciable, rizz)
        override this.OnInteraction other isAMatch =
            let difference = other.politicalView-this.politicalView 
            difference * this.influenciable


    // Skeptic person, er meget uvillig til at bevæge sig.
    type Skeptic(name: string, politicalview: float, influenciable: float, rizz: float) =
        inherit Participant(name, politicalview, influenciable, rizz)

        override this.OnInteraction other isAMatch =
            let difference = other.politicalView - this.politicalView
            difference * this.influenciable * (-1.0)

    let createMatrix(participantList: Participant List) =
        let mutable edgeMatrix = [||]
        for i in 0..participantList.Length - 1 do
            for person in participantList |> List.filter (fun p -> p.Id > uint i) do
                let agreeablity = person.MatchScore (participantList[i]) > 0.5
                edgeMatrix <- Array.append edgeMatrix [|(person.Id, participantList[i].Id, agreeablity)|]
        edgeMatrix


    let participant_list: Participant list = [
        CopyCat("David", 0.90, 0.01, 0.0);
        CopyCat("Linda",0.36, 0.04, 0.0);
        Skeptic("Patricia", 0.32, 0.07, 0.0);
        Normal("Thomas", 0.09, 0.06, 0.0);
        CopyCat("Jessica", 0.63, 0.01, 0.0);
        Normal("Christopher", 0.98, 0.05, 0.1);
        Skeptic("Elizabeth", 0.89, 0.04, 0.02);
        Normal("David", 0.78, 0.08, 0.01);
        Skeptic("Charlie Kirk", 1.0, 0.0, 1.0);
        Normal("Elizabeth", 0.89, 0.04, 0.10)
    ]

    createMatrix participant_list |> printfn "%A"