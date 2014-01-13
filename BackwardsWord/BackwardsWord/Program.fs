open StringUtil

[<EntryPoint>]
let main argv = 
    let backWords = Backwords()

    printf "%s\r\n" <| backWords.Parse "Robin"
    printf "%s\r\n" <| backWords.Parse "niboR"

    0 // return an integer exit code
