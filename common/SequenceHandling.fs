namespace Common

module SequenceHandling =  
    let SequenceContainsValue seq1 n = Seq.exists (fun x -> x = n) seq1
