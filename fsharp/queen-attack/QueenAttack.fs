module QueenAttack

let (|Valid|_|) value =
    if value >= 0 && value < 8 then Some Valid
    else None

let (|Row|Column|Diagonal|Cannot|) ((r1, c1), (r2, c2)) =
    match (r1, c1), (r2, c2) with
    | _ when r1 = r2 -> Row
    | _ when c1 = c2 -> Column
    | _ when abs (r1 - r2) = abs (c1 - c2) -> Diagonal
    | _ -> Cannot

let create (position: int * int) =
    match position with
    | (Valid, Valid) -> true
    | _ -> false

let canAttack (queen1: int * int) (queen2: int * int) =
    if (create queen1) && (create queen2) then
        match (queen1, queen2) with
        | Row | Column | Diagonal -> true
        | Cannot -> false
    else false