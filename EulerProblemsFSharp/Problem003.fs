module Problem003

let isDivisibleBy n d = n % d = 0I

let isDividedByAny numerator denominators =
    denominators
    |> List.where (numerator |> isDivisibleBy)
    |> List.isEmpty
    |> not


let firstPrime = 2I

let getNextPrime primes =
    let rec getNextPrimeRec foundPrimes primeCandidate =
        match (isDividedByAny primeCandidate foundPrimes) with
        | false -> primeCandidate
        | true -> getNextPrimeRec foundPrimes (primeCandidate + 1I)


    match primes with
    | head :: _ -> (getNextPrimeRec primes (head + 1I))
    | [] -> firstPrime


let getPrimeFactors number =
    let rec getPrimeFactorsRec number primesFullyChecked =
        let nextPrime = getNextPrime primesFullyChecked
        match number = 1I with
        | true -> []
        | false ->
            match (isDivisibleBy number nextPrime) with
            | true ->
                nextPrime
                :: (getPrimeFactorsRec (number / nextPrime) primesFullyChecked)
            | false -> getPrimeFactorsRec number (nextPrime :: primesFullyChecked)

    getPrimeFactorsRec number []

let getBiggestPrimeFactor number =
    let primeFactors = getPrimeFactors number
    printfn "Prime Factors: %A" primeFactors
    List.last primeFactors

let realNumber = 600_851_475_143I

let getResult () = getBiggestPrimeFactor realNumber
