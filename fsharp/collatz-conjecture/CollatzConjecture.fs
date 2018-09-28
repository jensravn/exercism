module CollatzConjecture

let rec stepsCount c n =
    match n with
    | n when n < 1 -> None
    | 1 -> Some c
    | _ ->
        match n % 2 with
        | 0 -> n / 2
        | _ -> 3*n + 1
        |> stepsCount (c+1)

let steps (number: int): int option = stepsCount number 0