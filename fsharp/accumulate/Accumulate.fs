module Accumulate

let accumulate<'a, 'b> (func: 'a -> 'b) (input: 'a list): 'b list =
    // [for n in input -> func n]
    [for n in input do yield func n]
    
    // let rec accumulateRecursive f l a =
    //     match l with
    //     | x::xs ->
    //         let newA = f(x) :: a
    //         accumulateRecursive f xs newA
    //     | [] -> a

    // accumulateRecursive func input List.empty<'b>
    // |> List.rev
