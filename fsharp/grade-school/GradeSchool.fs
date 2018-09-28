module GradeSchool

type School = Map<int, string list>

let empty: School = Map.empty

let grade (number: int) (school: School): string list =
    school
    |> Map.tryFind number
    |> Option.defaultValue []
    |> List.sort

let add (student: string) (gradeN: int) (school: School): School =
    gradeN
    |> Map.add
    |> (student::(grade gradeN school))
    |> school

let roster (school: School): (int * string list) list =
    school
    |> Map.toList