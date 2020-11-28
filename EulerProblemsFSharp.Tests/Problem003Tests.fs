module EulerProblemsFSharp.Tests


open NUnit.Framework

[<SetUp>]
let Setup () = ()

[<Test>]
let Test1 () = Assert.Pass()

[<Test>]
let IsDividedByAnyWorks () =
    let result = Problem003.isDividedByAny 4I [ 2I; 3I ]

    Assert.AreEqual(true, result)

let primeTestCases =
    [ [], 2I
      [ 2I ], 3I
      [ 3I; 2I ], 5I
      [ 5I; 3I; 2I ], 7I ]
    |> List.map (fun (primes, e) -> TestCaseData(primes, e))

[<TestCaseSource("primeTestCases")>]
let GetPrimesShouldReturnCorrectPrimes primes expected =
    let result = Problem003.getNextPrime primes

    Assert.AreEqual(expected, result)

[<Test>]
let getBiggestPrimeFactor2Returns2 () =
    let result = Problem003.getBiggestPrimeFactor (2I)

    Assert.AreEqual(2I, result)

[<Test>]
let getBiggestPrimeFactorContains101AsBiggestReturns101 () =
    let result =
        Problem003.getBiggestPrimeFactor (2I * 2I * 2I * 2I * 23I * 101I)

    Assert.AreEqual(101I, result)

[<Test>]
let Solution () =
    let result = Problem003.getResult ()

    Assert.AreEqual(6857I, result)
