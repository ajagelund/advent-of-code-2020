namespace Days.Day2001

open Common.FileHandling

module Part1 = 
    let Run = 
        printfn "== DAY 1 [1] == "
        let path = ".\\files\\2001.txt"
        let sumToFind = 2020

        // Read and convert to int
        let seqInt = readLines path |> Seq.map (int) |> Seq.sort

        // match function
        let isMatch n = Seq.exists (fun x -> x = (sumToFind-n)) seqInt

        // iterate through sequence and find matches
        let result = Seq.iter (fun elem -> if isMatch elem then printf "%i " elem) seqInt

        0
