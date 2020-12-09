namespace Days.Day2001

module Logic = 
    
    open Common
    open Common.FileHandling
    open Common.SequenceHandling

    let Run path sumToFind numValues =

        // 1. full list of values
        let seqInt = readLines path |> Seq.map (int) |> Seq.sort

        let isMatch n = Seq.exists (fun x -> x = (sumToFind-n)) seqInt
        // let result = Seq.iter (fun elem -> printf "%i " elem) seqInt
        let result = Seq.iter (fun elem -> if isMatch elem then printf "%i " elem) seqInt



        // // 2. pick the first value
        // // 3. pick one or more values

        // let initialList = Seq.take numValues seqInt

        // printfn "\nInitial list:"
        // initialList |> Print.SequenceOfIntInline

        // // seqInt |> Seq.sort |> Seq.iter (Print.SingleInt)



        // printfn "\nFinal set:"
        // finalSet |> Print.SequenceOfIntInline

        // printfn "Sum:"
        // finalSet |> Seq.sum |> Print.SingleInt

        0


// let CheckAccount account = 
//   match account with
//   | {Balance = b} when b < 10.00 -> Console.WriteLine("Balance is Low")
//   | {Balance = b} when b >= 10.00 && b <= 100.00 -> Console.WriteLine("Balance is OK")
//   | {Balance = b} when b > 100.00 -> Console.WriteLine("Balance is High")

        // let rec findSumValues seqValues seqIndex =
        //     let sum = Seq.sum seqValues
        //     match sum with
        //     | sumToFind | -> printfn ""

        // 4. sum & compare to sumToFind
        //   - if < sumToFind -> pick new values until end of list per value (starting from last index)
        //   - if > sumToFind -> pick new first value
        //   - if = sumToFind -> DONE!


        // // Select all values lower than half the 
        // let pickLower = Seq.sort seqInt |> Seq.takeWhile (fun elem -> elem < sumToFind/2)

        // // Make sequence contain the possible (higher) values to find
        // let possibleMatches = Seq.map ( (-) sumToFind) pickLower

        // // pickLower |> printSeq
        // // printfn "---"
        // // possibleMatches |> printSeq
        // // printfn "---"

        // possibleMatches |> 
        // Seq.iter (fun i -> 
        //     if SequenceContainsValue seqInt i then
        //         finalSet.Add(i)
        // )

