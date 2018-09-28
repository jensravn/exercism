module Bob
open System
open System.Text.RegularExpressions

let isUppercaseChar char =
    if(Char.IsLetter char)
        then Char.IsUpper char |> Some
        else None

let isUppercase string =
    let charSeq = Seq.toList string
    if(List.exists Char.IsLetter charSeq)
    then charSeq 
        |> List.filter Char.IsLetter
        |> List.forall Char.IsUpper
    else
        false

let stringEndsWith (string: string) char =
    string.Chars(string.Length-1) = char

let response string =
    let m = Regex.Match(string, "^(.*?)\s*$")
    if(m.Success)
    then
        let string = m.Groups.[1].Value
        if(Regex.IsMatch(string, "^\s*$"))
        then "Fine. Be that way!"
        else
            if(isUppercase string)
            then
                if(stringEndsWith string '?')
                then "Calm down, I know what I'm doing!"
                else "Whoa, chill out!"
            else
                if(stringEndsWith string '?')
                then "Sure."
                else "Whatever."
    else
        "Whatever."