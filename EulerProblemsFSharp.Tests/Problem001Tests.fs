module Problem001Tests


open NUnit.Framework
open Problem001

[<Test>]
let Solution () =
    let result = getResult ()

    Assert.AreEqual(233168, result)
