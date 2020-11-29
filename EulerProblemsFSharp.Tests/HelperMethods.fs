module HelperMethods

open NUnit.Framework

let rec AssertEqualValues (expectedList: 'a list) (list: 'a list) =
    printfn "ExpectedList: %A" expectedList
    printfn "ActualList: %A" list
    Assert.AreEqual(List.length expectedList, List.length list, "Länge sollte gleich sein.")

    match expectedList with
    | [] ->
        match list with
        | [] -> Assert.Pass()
        | _ :: _ -> Assert.Fail("List war kürzer.")

    | expectedHead :: expectedTail ->
        match list with
        | [] -> Assert.Fail("ExpectedList war kürzer.")
        | head :: tail ->
            Assert.AreEqual(expectedHead, head)
            AssertEqualValues expectedTail tail
