module Problem001

let either a b = 
    let x n = (a n) || (b n)
    x

let isDivisibleBy d n =
    match n%d with
    | 0 -> true
    | _ -> false

let isDivisibleByThree = isDivisibleBy <| 3
let isDivisibleByFive = isDivisibleBy <| 5
let isDivisibleByThreeOrFive n = n |> either isDivisibleByThree isDivisibleByFive
let filterByDivision list = list |> List.filter isDivisibleByThreeOrFive

let getNumbersBelow n= [1..n-1]
let getDivisibleNumbersBelow n = getNumbersBelow n |> filterByDivision  
let sum n = n |> getDivisibleNumbersBelow |> List.sum

let getResult () = 
    sum 1000

    