module BeerSong

let recite (startBottles: int) (takeDown: int) =
    let buildVerse = function
    | 0 -> ["No more bottles of beer on the wall, no more bottles of beer.";
            "Go to the store and buy some more, 99 bottles of beer on the wall."]
    | 1 -> ["1 bottle of beer on the wall, 1 bottle of beer.";
            "Take it down and pass it around, no more bottles of beer on the wall."]
    | 2 -> ["2 bottles of beer on the wall, 2 bottles of beer.";
            "Take one down and pass it around, 1 bottle of beer on the wall."]
    | i -> [sprintf "%d bottles of beer on the wall, %d bottles of beer." i i;
            sprintf "Take one down and pass it around, %d bottles of beer on the wall." (i-1)]

    let rec reciteRecursive acc splitVerses startBottles = function
    | 0 -> acc
    | i -> 
        let newVerse = buildVerse startBottles
        let verses = acc @ splitVerses @ newVerse
        reciteRecursive verses [""] (startBottles-1) (i-1)

    reciteRecursive [] [] startBottles takeDown