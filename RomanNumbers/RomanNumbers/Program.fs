// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.
open System

type Level(i:string, v:string, x:string) = 
    member this.i = i
    member this.v = v
    member this.x = x

let CalculateDigit (d:int, l:int, levels:List<Level>) = 
    if l > 2 then
        let loopEnd = d * int (10.0**(float l-3.0))
        let str = [1..loopEnd] |> List.map (fun i -> "M") |> String.concat ""
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
    let res = [0..intArr.Length-1] |> List.map (fun n -> CalculateDigit(intArr.[n], intArr.Length - n - 1, levels)) |> String.concat ""
    res

[<EntryPoint>]
let main argv = 

    let levels = [new Level("I", "V", "X"); new Level("X", "L", "C"); new Level("C", "D", "M")]

    printf "%s\r\n" <| ToRoman(86, levels)
    0 // return an integer exit code
