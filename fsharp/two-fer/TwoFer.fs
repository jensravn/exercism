module TwoFer

let message x = sprintf "One for %s, one for me." x

let twoFer (input: string option): string =
    match input with
    | Some input -> message input
    | None -> message "you"