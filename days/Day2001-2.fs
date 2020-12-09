namespace Days.Day2001

open Common.FileHandling

module Part2 = 
    let Run = 
        printfn "== DAY 1 [2] == "

        let path = ".\\files\\2001.txt"
        let sumToFind = 2020

        // Read and convert to int
        let listInt = readLines path |> Seq.map (int) |> Seq.sort |> Seq.toList

        // match function
        // recursive func taking .head + each number in .tail and look for sum

        // iterate through sequence and find matches




        0
