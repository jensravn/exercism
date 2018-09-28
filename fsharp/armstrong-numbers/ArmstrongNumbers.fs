module ArmstrongNumbers

let rec intToDigitsRec ds = function 
    | i when i >= 10 -> intToDigitsRec ((i%10)::ds) (i/10)
    | i -> i::ds

let intToDigits = intToDigitsRec []

let isArmstrongNumber (number: int) =
    let ds = number |> intToDigits
    let n = ds.Length
    
    ds
    |> List.sumBy (fun d -> pown d n)
    |> id = number