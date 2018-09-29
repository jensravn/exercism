module KindergartenGarden

type Plant =
| Clover
| Grass
| Radishes
| Violets

let plants (diagram: string) (student: string) =
    let charToPlant char =
        match char with
        | 'R' -> Plant.Radishes
        | 'C' -> Plant.Clover
        | 'G' -> Plant.Grass
        | 'V' -> Plant.Violets
        | c -> failwith (sprintf "Unknown char: %A" c)

    let studentToNumber student =
        match student with
        | "Alice" -> 0
        | "Bob" -> 1
        | "Charlie" -> 2
        | "David" -> 3
        | "Eve" -> 4
        | "Fred"-> 5
        | "Ginny" -> 6
        | "Harriet" -> 7
        | "Ileana" -> 8
        | "Joseph" -> 9
        | "Kincaid" -> 10
        | "Larry" -> 11
        | s -> failwith (sprintf "Unknown student: %A" s)

    let getStudentsPlants (plantSequence: string) = 
        let n = studentToNumber student
        plantSequence.[n*2..n*2+1]

    diagram.Split '\n'
    |> Seq.collect getStudentsPlants
    |> Seq.map charToPlant
    |> Seq.toList