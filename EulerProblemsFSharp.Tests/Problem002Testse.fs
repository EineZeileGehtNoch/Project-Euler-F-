module Problem002Tests


open NUnit.Framework
open Problem002

[<Test>]
let Solution () =
    let result = getResult ()

    Assert.AreEqual(4613732, result)
