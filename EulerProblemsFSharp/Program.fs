// Learn more about F# at http://fsharp.org

open System

let tryParse (str:String) =
    match Int32.TryParse str with
    | true, num -> Some num
    | _ -> None


let getProblem optionNumber = 
    match optionNumber with 
    | None -> None
    | Some number -> match number with
                        | 1 -> Some (number,(bigint (Problem001.getResult())))
                        | 2 -> Some (number,(bigint (Problem002.getResult())))
                        | 3 -> Some (number, Problem003.getResult())
                        | _ -> None

let rec programm () =
    printfn "Für nächstes Problem valide Zahl eingeben. Bei \"exit\" wird Programm beendet."
    let line = Console.ReadLine()  
    match line with 
     | "exit" -> printfn "Beende Programm."
     | _ ->     let problem = line |> tryParse
                let solution = problem  |> getProblem
    
                match solution with 
                | None -> printfn "Keine bekannte Nummer: \"%s\". Bitte andere Nummer eingeben." line
                | Some (number, result) -> printfn "Problem: %i, Lösung: %A" number result
                programm()

    
[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"

    programm()


    ignore <| Console.ReadLine()
    0 // return an integer exit code
