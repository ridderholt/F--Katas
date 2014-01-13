namespace StringUtil
type Backwords() = 
    member this.Parse (word:string) = 
        word.ToCharArray() |> Seq.toList |> List.rev |> List.map (fun c -> string c) |> String.concat ""

