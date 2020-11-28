module EulerProblemsFSharp.Tests


open NUnit.Framework

[<SetUp>]
let Setup () = ()


[<Test>]
let getBiggestPrimeFactor2Returns2 () =
    let result = Problem003.getBiggestPrimeFactor 2I

    Assert.AreEqual(2I, result)

[<Test>]
let getBiggestPrimeFactor4Returns2 () =
    let result = Problem003.getBiggestPrimeFactor 4I

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
