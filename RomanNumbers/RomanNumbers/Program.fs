open Roman


[<EntryPoint>]
let main argv = 

    let levels = [new Level("I", "V", "X"); new Level("X", "L", "C"); new Level("C", "D", "M")]
    let roman = LetThereBeRomans()

    printf "%s\r\n" <| roman.ToRoman(86, levels)

    0
