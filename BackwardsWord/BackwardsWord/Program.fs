// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

let ReverseWord (word:string) = 
    word.ToCharArray() |> Seq.toList |> List.rev |> List.map (fun c -> string c) |> String.concat ""


[<EntryPoint>]
let main argv = 

    printf "%s\r\n" <| ReverseWord "Robin"
    
    printf "%s\r\n" <| ReverseWord "niboR"

    0 // return an integer exit code
