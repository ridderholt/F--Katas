open Roman

[<EntryPoint>]
let main argv = 

    let roman = LetThereBeRomans()

    printf "%s\r\n" <| roman.ToRoman(86)

    0
