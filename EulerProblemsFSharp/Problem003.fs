module Problem003

let isDivisibleBy n d = n % d = 0I

let firstPrime = 2I

let getPrimeFactors number =
    let rec getPrimeFactorsRec number nextFactorToCheck =
        let nextPrime = nextFactorToCheck
        match number with
        | one when one = 1I -> []
        | _ ->
            match (isDivisibleBy number nextPrime) with
            | true ->
                nextPrime
                :: (getPrimeFactorsRec (number / nextPrime) nextPrime)
            | false -> getPrimeFactorsRec number (nextPrime + 1I)

    getPrimeFactorsRec number firstPrime

let getBiggestPrimeFactor number = getPrimeFactors number |> List.last

let realNumber = 600_851_475_143I

let getResult () = getBiggestPrimeFactor realNumber
