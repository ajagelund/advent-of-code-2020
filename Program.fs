// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open Days

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    // let message = from "F#" // Call the function
    // printfn "Hello world %s" message

    // let userinput = System.Console.ReadLine();
    // printfn ">> %s" userinput

// type Choices = A | B | C
// let x = 
//     match A with 
//     | A -> "a"
//     | B -> "b"
//     | C -> "c"
//     //NO default match

    let res1 = Day2001.Part1.Run
    // let res2 = Day2001.Part2.Run

    0
