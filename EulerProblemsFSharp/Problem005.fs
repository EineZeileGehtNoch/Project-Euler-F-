module Problem005

let rec appendReverse list prequel =
    match prequel with
    | [] -> list
    | head :: tail -> appendReverse (head :: list) tail

let getLeastCommonFactors factors1 factors2 =
    let rec getLeastCommonFactorsRec list1 list2 factors =
        match list1 with
        | [] -> list2 |> appendReverse factors
        | head1 :: tail1 ->
            match list2 with
            | [] -> list1 |> appendReverse factors
            | head2 :: tail2 ->
                match head1 with
                | _ when head1 < head2 -> getLeastCommonFactorsRec tail1 list2 (head1 :: factors)
                | _ when head1 > head2 -> getLeastCommonFactorsRec list1 tail2 (head2 :: factors)
                | _ -> getLeastCommonFactorsRec tail1 tail2 (head2 :: factors)

    getLeastCommonFactorsRec factors1 factors2 []
    |> List.rev



let getPrimeFactorsForUpTo n =
    [ 1 .. n ]
    |> List.map (bigint >> Problem003.getPrimeFactors)
    |> List.fold getLeastCommonFactors []


let multiply numbers = List.fold (*) 1I numbers

let getLeastCommonMultipleForFactorsUpTo n = n |> getPrimeFactorsForUpTo |> multiply

let getResult () = getLeastCommonMultipleForFactorsUpTo 20
