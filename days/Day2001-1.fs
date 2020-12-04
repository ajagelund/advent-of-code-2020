namespace Days

module Day2001 = 
    
    open Common.FileHandling

    let Run =
        let content = readLines ".\\files\\2001-1.txt"
        let sumToFind = 2020

        // Print function - handles sequence of int
        let printSeq seq1 = Seq.iter (printf "%i\n") seq1; printfn ""
        let printInt i = (printf "%i\n") i

        let doExist seq1 n = Seq.exists (fun x -> x = n) seq1

        // Cast from string to int
        let seqInt = Seq.map (fun x -> int x) content


        // Select all values lower than half the 
        let pickLower = Seq.sort seqInt |> Seq.takeWhile (fun elem -> elem < sumToFind/2)

        // Make sequence contain the possible (higher) values to find
        let possibleMatches = Seq.map ( (-) sumToFind) pickLower

        // Find matching values in original sequence
        // let matches = Set.intersect a b

        pickLower |> printSeq
        printfn "---"
        possibleMatches |> printSeq
        printfn "---"

        possibleMatches |> Seq.iter (fun i -> if doExist seqInt i then printInt i)
        // matches |> printSeq

        0
