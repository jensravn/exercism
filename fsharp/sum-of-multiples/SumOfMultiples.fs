module SumOfMultiples

let hasDivider dividers number =
    List.exists (fun x -> number % x = 0) dividers

let sum (numbers: int list) (upperBound: int): int = 
    [1..upperBound-1]
    |> List.filter (hasDivider numbers)
    |> List.sum