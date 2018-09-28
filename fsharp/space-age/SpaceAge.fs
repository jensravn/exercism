module SpaceAge

// TODO: define the Planet type
type Planet =
| Earth
| Mercury
| Venus
| Mars
| Jupiter
| Saturn
| Uranus
| Neptune

let convertYears planet num =
    match planet with
    | Earth -> num
    | Mercury -> num / 0.2408467
    | Venus -> num / 0.61519726
    | Mars -> num / 1.8808158
    | Jupiter -> num / 11.862615
    | Saturn -> num / 29.447498
    | Uranus -> num / 84.016846
    | Neptune -> num / 164.79132

let toYears seconds =
    float seconds / float 31557600L

let roundOfTo2Decimals (float: float) =
    System.Math.Round(float, 2)

let age (planet: Planet) (seconds: int64): float = 
    seconds
    |> toYears
    |> convertYears planet
    |> roundOfTo2Decimals