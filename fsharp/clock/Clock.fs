module Clock

let minutesInDay clockInMinutes = clockInMinutes % (24 * 60)

let positiveClockMinutes normalizedMinutes =
        if normalizedMinutes < 0
        then (24 * 60) + normalizedMinutes
        else normalizedMinutes 

let create hours minutes = 
    hours * 60 + minutes
    |> minutesInDay
    |> positiveClockMinutes    

let add minutes clock = clock + minutes

let subtract minutes clock = clock - minutes

let display clockInMinutes = 
    let positiveClockMinutes = 
        clockInMinutes
        |> minutesInDay
        |> positiveClockMinutes    

    let hours = positiveClockMinutes / 60
    let minutes = positiveClockMinutes % 60
    sprintf "%02i:%02i" hours minutes