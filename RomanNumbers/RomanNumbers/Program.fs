open Roman 

let roman = LetThereBeRomans()

let rNum = "MCCCXXXVII"

let filterRoman(n:int) = 
    printf "%d\r\n" n
    roman.ToRoman(n) = rNum

[<EntryPoint>]
let main argv = 


//    printf "%s\r\n" <| roman.ToRoman(86)

    let force = [1..3000]

    force |> List.filter (fun n -> filterRoman n ) |> List.head |> printf "%d\r\n"

    0
