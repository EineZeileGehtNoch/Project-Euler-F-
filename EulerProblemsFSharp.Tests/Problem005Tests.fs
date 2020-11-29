module Problem005Tests


open NUnit.Framework
open Problem005
open HelperMethods

let getLeastCommonFactosTestCases =
    [ [ 2 ], [ 2 ], [ 2 ]
      [ 2 ], [ 3 ], [ 2; 3 ]
      [ 3 ], [ 2 ], [ 2; 3 ]
      [ 2; 2 ], [ 2 ], [ 2; 2 ]
      [ 2 ], [ 2; 2 ], [ 2; 2 ]
      [ 2; 3; 3 ], [ 2; 2; 3 ], [ 2; 2; 3; 3 ]
      [ 2; 2; 3 ], [ 2; 3; 3 ], [ 2; 2; 3; 3 ]
      [ 2 ], [ 2; 3 ], [ 2; 3 ] ]
    |> List.map (fun (first, second, expected) -> TestCaseData(first, second, expected))

[<TestCaseSource("getLeastCommonFactosTestCases")>]
let getLeastCommonFactorsShouldAddIfDistinct first second expected =
    let result = getLeastCommonFactors first second

    AssertEqualValues expected result

[<Test>]
let multiplyShouldReturnProduct () =
    let result = multiply [ 2I; 3I ]

    Assert.AreEqual(6I, result)

let getLeastCommonMultipleForFactorsUpToTestCases =
    [ 2, 2I; 3, 6I; 4, 12I; 10, 2520I ]
    |> List.map (fun (maximum, expected) -> TestCaseData(maximum, expected))

[<TestCaseSource("getLeastCommonMultipleForFactorsUpToTestCases")>]
let getLeastCommonMultipleForFactorsUpTo2ShouldReturn2 maximum expected =
    let result =
        getLeastCommonMultipleForFactorsUpTo maximum

    Assert.AreEqual(expected, result)

[<Test>]
let Solution () =
    let result = getResult ()

    Assert.AreEqual(232792560I, result)
