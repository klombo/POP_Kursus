module MeetUp

[<AbstractClass>]
type Participant =
    interface System.IComparable
    new: name: string * politicalview: float * influenciable: float * rizz: float -> Participant
    override Equals: something: obj -> bool
    override GetHashCode: unit -> int
    abstract MatchScore: other: Participant -> float
    abstract OnInteraction: other: Participant -> isAMatch: bool -> float
    member Id: uint32
    member influenciable: float
    member name: string
    member politicalView: float with get, set
    member rizz: float

type Normal =
    inherit Participant
    new: name: string * politicalview: float * influenciable: float * rizz: float -> Normal

type CopyCat =
    inherit Participant
    new: name: string * politicalview: float * influenciable: float * rizz: float -> CopyCat
    override OnInteraction: other: Participant -> isAMatch: bool -> float

type Skeptic =
    inherit Participant
    new: name: string * politicalview: float * influenciable: float * rizz: float -> Skeptic
    override OnInteraction: other: Participant -> isAMatch: bool -> float

type SimulationState =
    { Participants : Participant list
      Log          : string list 
      Runde        : int}

val simulateMeeting: participantList: List<Participant> -> (Participant * Participant * bool)

val createEdgeMatrix: participantList: List<Participant> -> (Participant * Participant * bool) array

val createGraph: participants: List<Participant> -> connections: (Participant * Participant * bool) array -> simpleGraph.Graph<Participant>

val outerRadius: float

val circleRadius: float

val dAngle: float

val pointPolar: (float * float) -> (float * float) -> (float * float)

val line: Canvas.color -> (float * float) -> (float * float) -> Canvas.PrimitiveTree

val makeCircle: Canvas.color -> (float * float) -> Canvas.PrimitiveTree

val buildPicture: SimulationState -> (float * float) -> Canvas.Picture

val react: state: SimulationState -> ev: Canvas.Event -> SimulationState option

val runSimulation: Participant List -> int * int -> int Option -> unit