module MeetUp

open simpleGraph
open Canvas
open Color
open System

[<AbstractClass>]
type Participant (name: string, politicalview: float, influenciable: float, charisma: float) =

    static let mutable _latestID = 0u
    do _latestID <- _latestID + 1u
    let _id = _latestID

    let mutable _politicalview = politicalview
    
    let _influenciable = influenciable
    let _charisma = charisma
    let _name = name

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

    member this.politicalView 
        with get() = _politicalview
        and set(value) =
            if value < 0.0 then
                _politicalview <- 0.0
            elif value > 1.0 then 
                _politicalview <- 1.0
            else 
                _politicalview <- value

    member this.influenciable = _influenciable

    member this.charisma = _charisma

    member this.name = _name

    abstract member OnInteraction: other: Participant -> isAMatch : bool -> float
    default this.OnInteraction other isAMatch =  
        let politicalViewDistance = other.politicalView - this.politicalView
        let influenceStrength = this.influenciable * other.charisma - 1.0
        let moveAmount = influenceStrength * (politicalViewDistance * politicalViewDistance) + abs(politicalViewDistance)
        if politicalViewDistance > 0 then (moveAmount * 0.25)
        else (-moveAmount * 0.25)


    abstract member MatchScore: other: Participant -> float
    default this.MatchScore other = 
        let politicalViewDistance = this.politicalView - other.politicalView
        1.0 - (abs politicalViewDistance)


// Normal person, bevæger sig normalt
type Normal(name: string, politicalview: float, influenciable: float, charisma: float) =
    inherit Participant(name, politicalview, influenciable, charisma)


// Copycat person, bliver bare det samme som den person de møder.
type CopyCat(name: string, politicalview: float, influenciable: float, charisma: float) =
    inherit Participant(name, politicalview, influenciable, charisma)
    override this.OnInteraction other isAMatch =
        let politicalViewDistance = other.politicalView - this.politicalView 
        let influenceStrength = this.influenciable * other.charisma
        politicalViewDistance * influenceStrength


// Skeptic person, er meget uvillig til at bevæge sig.
type Skeptic(name: string, politicalview: float, influenciable: float, charisma: float) =
    inherit Participant(name, politicalview, influenciable, charisma)
    override this.OnInteraction other isAMatch =
        let politicalViewDistance = other.politicalView - this.politicalView
        let influenceStrength = this.influenciable * other.charisma
        politicalViewDistance * influenceStrength * (-1.0)

// En type der gemmer particpant list, de seneste møder og runde antal.
type SimulationState = {
    Participants : Participant list
    Log          : string list
    Runde        : int   
}

// Funktion der simulere mødet mellem to personer.
let simulateMeeting(participantList: Participant List) : Participant * Participant * bool =
    let person1, person2 = 
        match participantList |> List.randomSample 2 with
        | [person1; person2] -> person1, person2
        | _ -> failwith "Expected 2 values"

    let isAMatch = person1.MatchScore person2 > 0.5

    let p1PoliticalMovement = person1.OnInteraction person2 isAMatch
    let p2PoliticalMovement = person2.OnInteraction person1 isAMatch

    person1.politicalView <- person1.politicalView + p1PoliticalMovement
    person2.politicalView <- person2.politicalView + p2PoliticalMovement

    person1, person2, isAMatch

// laver Array, som indeholder hvilke kanter der skal tegnes mellem hvilke personer
let createEdgeMatrix(participantList: Participant List) : (Participant* Participant * bool) array =
    let mutable edgeMatrix = [||]
    for i in 0..participantList.Length - 1 do
        for person in participantList |> List.filter (fun p -> p.Id > uint i+1u) do
            let agreeablity = person.MatchScore (participantList[i]) > 0.5
            edgeMatrix <- Array.append edgeMatrix [|(person, participantList[i], agreeablity)|]
    edgeMatrix

// Funktion der laver grafen med forbindelserne mellem de forskellige personer.
let createGraph (participants: Participant List) (connections: (Participant * Participant * bool) array) : Graph<Participant> =
    let emptyGraph : Graph<Participant> = empty
    
    let participantGraphOnlyVertices =
        participants
        |> List.fold (fun g v -> addVertex v g) emptyGraph

    let completeParticipantGraph =
        connections
        |> Array.fold (fun g (u, v, x) ->
            if x then addEdge u v g
            else g
            ) participantGraphOnlyVertices

    completeParticipantGraph

// Render // Render // Render // Render
let circleRadius = 35.0
let outerRadius = 250.0
let dAngle = 0.1

let pointPolar (x1,x2) (r,t) =
    x1 + r * cos t, x2 + r * sin t

// Funktion der tegner en linje mellem 2 punkter, baseret på circleRadius.
let line color center (a1,a2) : PrimitiveTree =
    let point0 = pointPolar center (circleRadius, a1)
    let point1 = pointPolar center (circleRadius, a2)
    piecewiseAffine color 1.0 [point0; poinnt1]

// Funktion der tegner en normal cirkle.
let makeCircle color center =
    let rec loop pair =
        if snd pair <= 2.0 * Math.PI then
            let nextPair = snd pair, dAngle + snd pair
            onto (line color center pair) (loop nextPair)
        else
            let finalPair = (fst pair, 2.0 * Math.PI)
            line color center finalPair
    loop (0.0, dAngle)

// Funktion der tegner og samler alle de forskellige dele af grafen.
let buildPicture (state: SimulationState) (midPoint : float * float) : Picture =
    let numberOfCircles = state.Participants.Length
    let fontName = "Microsoft Sans Serif"
    let font = makeFont fontName 14.0

    // Funktion der returnere en liste med personer, midten af deres circle og deres circle PrimitiveTree.
    let circleData = 
        state.Participants 
        |> List.mapi (fun i person ->
            let placementAngle = 2.0 * Math.PI / float numberOfCircles * float i
            let xOffset = outerRadius * cos placementAngle
            let yOffset = outerRadius * sin placementAngle
            let center = fst midPoint + xOffset, snd midPoint + yOffset

            // VÆLG FARVE baseret på politicalView
            let color = if person.politicalView > 0.5 then blue else red

            // Lav cirkel med den farve
            let circleTree = makeCircle color center
            person, center, circleTree
        )
    
    // Funktion der returnere alle circleTree fra circleData listen.
    let circles =
        circleData
        |> List.map (fun (_, _, circleTree) -> circleTree)

    // Giver en liste med circle midt koordinaterne baseret på person ID.
    let centerOf =
        circleData
        |> List.map (fun (p, center, _) -> p.Id, center)
        |> Map.ofList
    
    // Funktion der tegner kanten mellem to cirkler
    let makeEdgeLine (c1x, c1y) (c2x, c2y) =
        let distanceOnXAxis = c2x - c1x
        let distanceOnYAxis = c2y - c1y
        let distance = sqrt (distanceOnXAxis*distanceOnXAxis + distanceOnYAxis*distanceOnYAxis)
        if distance = 0.0 then
            emptyTree  // Hvis to punkter er identiske
        else
            // Enhedsvektor fra midten af circle 1 og midten af circle 2
            let ratioOnXAxis = distanceOnXAxis / distance
            let ratioOnYAxis = distanceOnYAxis / distance

            // Start og slut skubbes ind så linjen starter/slutter på cirkelkanten
            let startPoint = c1x + ratioOnXAxis * circleRadius, c1y + ratioOnYAxis * circleRadius
            let endPoint   = c2x - ratioOnXAxis * circleRadius, c2y - ratioOnYAxis * circleRadius

            piecewiseAffine white 1.0 [startPoint; endPoint]
    
    // Funktion til at lave kanten tegninger ud fra edgeMatrix
    let edgeLines =
        createEdgeMatrix state.Participants
        |> Array.choose (fun (person1, person2, isMatch) ->
            if isMatch then
                let person1CenterCoordinates = centerOf[person1.Id]
                let person2CenterCoordinates = centerOf[person2.Id]
                Some (makeEdgeLine person1CenterCoordinates person2CenterCoordinates)
            else
                None)
        |> Array.toList
    
    // Funktion til at skrive alle politicalViews i de rigtige bobler
    let drawPoliticalViews =
        circleData
        |> List.map (fun (p, (x,y), _) ->
            let politicalViewString = (p.politicalView.ToString())[..4]
            let textSize = measureText font politicalViewString
            let textOffsetX = (fst textSize)/2.
            let textOffsetY = (snd textSize)/2.
            text white font (politicalViewString)
            |> translate (x - textOffsetX) (y - textOffsetY)
        )

    // Funktion der viser skriver tallet der viser hvor mange TimerTick events har kørt
    let showrunde = 
        let rundeTekst = state.Runde.ToString()
        let textSize = measureText font rundeTekst
        let textOffset = (snd textSize) * 1.5
        text white font ("runde: " + rundeTekst)
        |> translate 0 (700.0 - textOffset)

    // Funktion der skriver det seneste møde på skræmen.
    let logLinesTrees =
        state.Log
        |> List.truncate 1    // hvor mange logs der er 
        |> List.mapi (fun i line ->
            text white font line
        )

    // Laver figuren så den inderholder alle Primitive Trees circles, edgelines, politicalView tekst og runde tekst
    let fig = 
        circles @ edgeLines @ drawPoliticalViews @ [showrunde] @ logLinesTrees
        |> List.fold (fun acc x -> onto x acc) emptyTree

    make fig 

// Funktion der håndtere hvert TimerTick, interval, kører simulateMeeting med participants liste.
let react (state: SimulationState) (ev: Event) : SimulationState option =
    match ev with
    | Event.TimerTick ->
        let p1, p2, isMatch = simulateMeeting state.Participants
        let msg = 
            sprintf "%s møder %s (match=%b, views=%.2f og %.2f)"
                p1.name p2.name isMatch p1.politicalView p2.politicalView
        let newLog = 
            msg :: state.Log
            |> List.truncate 2
        Some { state with Log = newLog; Runde = state.Runde + 1}
    | _ ->
        None

// Funktion vi kalder fra meetUpExamples.fsx filen.
let runSimulation(participantList: Participant List)=
    let width = 700
    let height = 700
    let interval = (Some 250)
    let midPoint = float width * 0.5, float height * 0.5

    let initialState : SimulationState =
        { Participants = participantList
          Log = [] 
          Runde = 0}

    let draw (state: SimulationState): Picture = 
        buildPicture state midPoint
    
    interact "Graf" width height interval draw react initialState