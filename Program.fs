// Learn more about F# at http://docs.microsoft.com/dotnet/fsharp

open System
open Common.FileHandling

// Define a function to construct a message to print
let from whom =
    sprintf "from %s" whom

[<EntryPoint>]
let main argv =
    let message = from "F#" // Call the function
    printfn "Hello world %s" message

    let content = readLines ".\\files\\2001-1.txt"

    let list = Seq.map (fun x -> int x) content
    
    Seq.sort list 
        |> Seq.iter (printf "%s\n")

    // for line in content.sort do
    //     printfn "%s" line
    0 // return an integer exit code