module Leap

let (|DivisibleBy|_|) by value =
    if value % by = 0
    then Some DivisibleBy
    else None

let leapYear = function
| DivisibleBy 400 -> true
| DivisibleBy 100 -> false
| DivisibleBy 4 -> true
| _ -> false