module Drone
type vector = float * float

let pythagoras (x: float, y: float): float = sqrt(x*x + y*y)

type drone(position: vector, centimeterPerSecond: float, destination: vector) =
    let mutable _position = position
    let mutable _speed = centimeterPerSecond
    let mutable _destination = destination

    member this.position
        with get() = _position
        and set position = _position <- position
    
    member this.speed
        with get() = _speed
        and set speed = _speed <- speed

    member this.destination
        with get() = _destination
        and set destination = _destination <- destination
    
    member this.atDestination =
        if _position = _destination then true 
        else false

    member this.fly() =
        let distanceOnXAxis = fst _destination - fst _position
        let distanceOnYAxis = snd _destination - snd _position
        
        let distance = pythagoras (distanceOnXAxis, distanceOnYAxis)

        if distance <= _speed then
            _position <- _destination
        else 
            let scaleOnXAxis = distanceOnXAxis/distance
            let scaleOnYAxis = distanceOnYAxis/distance
            let newPositionOnXAxis = fst _position + scaleOnXAxis * _speed
            let newPositionOnYAxis = snd _position + scaleOnYAxis * _speed
            _position <- newPositionOnXAxis, newPositionOnYAxis

type airSpace(droneListe: drone list) =
    
    let mutable _droneListe = droneListe

    member this.droneDist(drone1: drone, drone2: drone) =
        let distanceOnXAxis = fst drone1.position - fst drone2.position
        let distanceOnYAxis = snd drone1.position - snd drone2.position

        let distance = pythagoras(distanceOnXAxis, distanceOnYAxis)
        distance
    
    member this.flyDrones() =
        for flyvendeDrone in _droneListe do
            flyvendeDrone.fly()
    
    member this.addDrone(nyDrone: drone) =
        _droneListe <- _droneListe @ [nyDrone]

    member this.Collided() =
        for i in 0.._droneListe.Length-1 do
            for j in i+1.._droneListe.Length-1 do
                if this.droneDist (_droneListe[i], _droneListe[j]) <= 5 then
                    



    


let drone1 = drone((0,0), 1, (3,4))
printfn "%A" drone1.position
drone1.fly()
printfn "%A" drone1.position
drone1.fly()
printfn "%A" drone1.position
drone1.fly()
printfn "%A" drone1.position
drone1.fly()
printfn "%A" drone1.position
drone1.fly()
printfn "%A" drone1.position