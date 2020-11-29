module Problem004

let getDigits number =
    let rec digitsRec restNumber =
        let digit = restNumber % 10
        let rest = restNumber / 10
        match rest with
        | 0 -> [ digit ]
        | _ -> digit :: digitsRec rest

    digitsRec number |> List.rev


let isPalyndrome number =
    let digits = getDigits number
    let reverseDigits = digits |> List.rev
    digits = reverseDigits

let multiply (pair: int * int) =
    match pair with
    | (first, second) -> first * second


let combineToBiggestPalyndrome list1 list2 =
    0
    :: (List.allPairs list1 list2
        |> List.map multiply
        |> List.where isPalyndrome)
    |> List.max

let rec power number potency =
    match potency with
    | 0 -> 1
    | _ -> number * (power number (potency - 1))

let getNDigitNumbers numberOfDigits =
    let smallest = power 10 (numberOfDigits - 1)
    let biggest = (power 10 numberOfDigits) - 1
    printfn "%A" smallest
    printfn "%A" biggest

    [ smallest .. biggest ]


let getBiggestPalyndromeWithNDigits numberOfDigits =
    let list = getNDigitNumbers numberOfDigits
    combineToBiggestPalyndrome list list

let getResult () = getBiggestPalyndromeWithNDigits 3
