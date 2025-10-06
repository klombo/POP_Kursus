(* Assume that you have a list of students. 
Each student has a unique name (a string), 
and a score (an integer from 0 to 4).
Our problem is to create groups of three 
students so that students with identical 
scores are grouped together as much as possible. *)

type Student = { Name: string; Score: int }

let students : Student list =
    [
        { Name = "Alice"; Score = 3 }
        { Name = "Bob"; Score = 2 }
        { Name = "Charlie"; Score = 4 }
        { Name = "Diana"; Score = 1 }
        { Name = "Ethan"; Score = 0 }
        { Name = "Fiona"; Score = 2 }
        { Name = "George"; Score = 4 }
        { Name = "Hannah"; Score = 3 }
        { Name = "Ian"; Score = 1 }
        { Name = "Julia"; Score = 2 }
        { Name = "Kevin"; Score = 0 }
        { Name = "Laura"; Score = 3 }
        { Name = "Michael"; Score = 4 }
        { Name = "Nina"; Score = 2 }
        { Name = "Oscar"; Score = 1 }
        { Name = "Paula"; Score = 3 }
        { Name = "Quentin"; Score = 0 }
        { Name = "Rachel"; Score = 4 }
        { Name = "Sam"; Score = 2 }
        { Name = "Tina"; Score = 1 }
        { Name = "Uma"; Score = 3 }
        { Name = "Victor"; Score = 4 }
        { Name = "Wendy"; Score = 2 }
        { Name = "Xavier"; Score = 1 }
        { Name = "Yvonne"; Score = 0 }
    ]


// Create lists of names with the same score.

let grouped (students: Student list) = 
    students 
    |> List.groupBy(fun s -> s.Score)
    |> List.map (fun (_, tal)->tal)

// Vi tager students og piper den igennem List.groupBy og igennem List.map
// Det betyder så at vi grouper den baseret på Score.
// Vi får et output som er en liste med lister over alle med samme Scores.

let g0 = students |> List.filter (fun s -> s.Score = 0)
let g1 = students |> List.filter (fun s -> s.Score = 1)
let g2 = students |> List.filter (fun s -> s.Score = 2)
let g3 = students |> List.filter (fun s -> s.Score = 3)
let g4 = students |> List.filter (fun s -> s.Score = 4)


let rec group_of_three (l: 'a list) =
    match l.Length with
    |0|1|2 -> []
    |_ -> (l[0], l[1], l[2])::(group_of_three l[3..])

printfn "%A" (group_of_three (g0))
printfn "%A" (group_of_three (g1))
printfn "%A" (group_of_three (g2))
printfn "%A" (group_of_three (g3))
printfn "%A" (group_of_three (g4))
