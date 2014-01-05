// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open System

type Level(i:string, v:string, x:string) = 
    member this.i = i
    member this.v = v
    member this.x = x

let CalculateDigit (d:int, l:int, levels:List<Level>) = 
    if l > 2 then
        let mutable str = ""
        for m = 1 to (d * (Convert.ToInt32(Math.Pow(float 10, float (l-3))))) do 
            str <- String.Concat(str, "M")
        str
    else
        let index = int l
        match d with
        | 1 -> levels.[index].i
        | 2 -> String.Concat(levels.[index].i, levels.[index].i)
        | 3 -> String.Concat(levels.[index].i, levels.[index].i, levels.[index].i)
        | 4 -> String.Concat(levels.[index].i, levels.[index].v)
        | 5 -> levels.[index].v
        | 6 -> String.Concat(levels.[index].v, levels.[index].i)
        | 7 -> String.Concat(levels.[index].v, levels.[index].i, levels.[index].i)
        | 8 -> String.Concat(levels.[index].v, levels.[index].i, levels.[index].i, levels.[index].i)
        | 9 -> String.Concat(levels.[index].i, levels.[index].x)
        | _ -> ""

let ToRoman (num:int, levels:List<Level>) = 
    let intArr = num.ToString() |> Seq.map (fun x -> Convert.ToInt32(string x)) |> Seq.toArray
    let mutable res = ""
    for c = 0 to intArr.Length - 1 do
        res <- String.Concat(res, CalculateDigit(intArr.[c], intArr.Length - c - 1, levels))
    res


[<EntryPoint>]
let main argv = 

    let levels = [new Level("I", "V", "X"); new Level("X", "L", "C"); new Level("C", "D", "M")]

    printf "%s\r\n" <| ToRoman(86, levels)
    0 // return an integer exit code
