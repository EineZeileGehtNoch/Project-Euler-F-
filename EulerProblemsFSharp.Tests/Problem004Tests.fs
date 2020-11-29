module Problem004Tests


open NUnit.Framework
open Problem004
open HelperMethods

[<SetUp>]
let Setup () = ()


[<Test>]
let ditits0ShouldReturn0 () =
    let result = getDigits 0

    Assert.AreEqual([ 0 ], result)

[<Test>]
let ditits9ShouldReturn9 () =
    let result = getDigits 9

    Assert.AreEqual([ 9 ], result)

[<Test>]
let ditits91ShouldReturn91 () =
    let result = getDigits 91

    AssertEqualValues [ 9; 1 ] result

[<Test>]
let isPalyndrome11ShouldBeTrue () =
    let result = 11 |> isPalyndrome

    Assert.True(result)

let isPalyndromeTestCases =
    [ 0, true
      11, true
      121, true
      12, false
      119, false ]
    |> List.map (fun (number, isPalyndrome) -> TestCaseData(number, isPalyndrome))

[<TestCaseSource("isPalyndromeTestCases")>]
let isPalyndromeShouldReturnCorrectResult number (expect: bool) =
    let result = number |> isPalyndrome

    Assert.AreEqual(expect, result)

[<Test>]
let combineToBiggestPalyndromeSingleValidCombinationShouldReturnPalyndrome () =
    let result = combineToBiggestPalyndrome [ 11 ] [ 5 ]

    Assert.AreEqual(55, result)

[<Test>]
let getNDigitNumbers1ShouldGive1To9 () =
    let result = getNDigitNumbers 1

    AssertEqualValues [ 1 .. 9 ] result

[<Test>]
let getNDigitNumbers2ShouldGive10To99 () =
    let result = getNDigitNumbers 2

    AssertEqualValues [ 10 .. 99 ] result

[<Test>]
let combineToBiggestPalyndromeNoValidCombinationShouldReturn0 () =
    let result = combineToBiggestPalyndrome [ 2 ] [ 5 ]

    Assert.AreEqual(0, result)

[<Test>]
let getBiggestPalyndromeWith1DigitShouldReturn9 () =
    let result = getBiggestPalyndromeWithNDigits 1

    Assert.AreEqual(9, result)

[<Test>]
let getBiggestPalyndromeWith2DigitsShouldReturn9009 () =
    let result = getBiggestPalyndromeWithNDigits 2

    Assert.AreEqual(9009, result)

[<Test>]
let Solution () =
    let result = getResult ()

    Assert.AreEqual(906609, result)
