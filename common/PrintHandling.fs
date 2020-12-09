namespace Common

module Print =
    let SequenceOfInt seq1 = Seq.iter (printf "%i\n") seq1; printfn ""
    let SequenceOfIntInline seq1 = Seq.iter (printf "- %i ") seq1; printfn "-"
    let SingleInt i = (printf "%i\n") i
