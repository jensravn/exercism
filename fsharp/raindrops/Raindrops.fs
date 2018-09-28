module Raindrops

let convert n = 
    let numberToText (d, t) =
        if n % d = 0
        then Some t
        else None

    let TextsOrInputNumber = function
        | [] -> n.ToString()
        | xs -> String.concat "" xs

    [(3, "Pling"); (5, "Plang"); (7, "Plong")]
    |> List.map numberToText
    |> List.choose id
    |> TextsOrInputNumber