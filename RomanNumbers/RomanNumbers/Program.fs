open Roman 

let roman = LetThereBeRomans()

let rNum = "MCCCXXXVII"

let filterRoman(n:int) = 
    roman.ToRoman(n) = rNum

[<EntryPoint>]
let main argv = 


//    printf "%s\r\n" <| roman.ToRoman(86)

    let force = [1..3000]

    force |> List.find (fun n -> filterRoman n ) |> printf "%d\r\n"

    0
