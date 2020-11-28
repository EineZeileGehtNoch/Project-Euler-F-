module Problem002


let rec Fib (first:int) (second:int) =
    seq{ yield first
         yield! (Fib second (first+second))
    }

let Fib123 = Fib 1 2

let even n =
    n%2=0

let filterEven =   
    Seq.filter even 

let NotGreaterThanFourMillion = 
     Seq.takeWhile (fun n -> n <= 4_000_000)


let getResult () =
    Fib123 
    |> NotGreaterThanFourMillion 
    |> filterEven 
    |> Seq.sum