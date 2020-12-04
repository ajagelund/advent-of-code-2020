// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open Days

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let message = from "F#" // Call the function
    printfn "Hello world %s" message

    // let userinput = System.Console.ReadLine();
    // printfn ">> %s" userinput

// type Choices = A | B | C
// let x = 
//     match A with 
//     | A -> "a"
//     | B -> "b"
//     | C -> "c"
//     //NO default match


 

    Day2001.Run

    // for line in content.sort do
    //     printfn "%s" line
    // return an integer exit code