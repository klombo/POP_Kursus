[<AbstractClass>]
type Participant (name: string, politicalview: float, influenciable: float) =

    // This is a minimal implementation of Participant. You are welcome to
    // add your own fields, functions, properties and methods.

    // Replace _id code with your own for generating a unique unsigned
    // integer for each participant
    let _id = 0u
    let mutable _politicalview = politicalview
    let mutable _influenciable = influenciable

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
    member val Influenciable = 0.5 with get, set
    member val PoliticalView = 0.5 with get, set
 
    /// A score on how well two participants are similar politically
    /// MatchScore is 1.0 if it is a perfect match and 0.0 if the opposite
    abstract member MatchScore: other: Participant -> float
    default this.MatchScore other = 
        let diff = this.PoliticalView-other.PoliticalView
        1.0 - (System.Math.Abs diff)
    /// Calculate how much the political views should change for this 
    /// participant when meeting another. If the match is good, then this should
    /// move in the diretion of the other, if it's bad then it should move in 
    /// the away from other
    abstract member OnInteraction: other:Participant -> isAMatch:bool -> float