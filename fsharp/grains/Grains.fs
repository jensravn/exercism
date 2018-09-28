module Grains

let square (n: int): Result<uint64,string> =
    let rec recSquare acc counter =
        match counter with
        | c when c < n -> recSquare (acc*(uint64 2)) (c+1)
        | _ -> acc

    match n with
    | n when n > 0 && n <=64 -> Ok (recSquare (uint64 1) 1)
    | _ -> Error "Invalid input"

// match n with
//     | n when n > 0 && n <=64 -> Ok (1UL<<<(n-1))
//     | _ -> Error "Invalid input"

let resultToOption x =
    match x with
    | Ok (x) -> Some(x)
    | Error (_) -> None

let total: Result<uint64,string> =
    [1..64]
    |> List.map square
    |> List.choose resultToOption
    |> List.sum
    |> Ok