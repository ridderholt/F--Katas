﻿// Learn more about F# at http://fsharp.net
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
        match d with
        | 1 -> levels.[l].i
        | 2 -> [levels.[l].i; levels.[l].i] |> String.concat ""
        | 3 -> [levels.[l].i; levels.[l].i; levels.[l].i] |> String.concat ""
        | 4 -> [levels.[l].i; levels.[l].v] |> String.concat ""
        | 5 -> levels.[l].v
        | 6 -> [levels.[l].v; levels.[l].i] |> String.concat ""
        | 7 -> [levels.[l].v; levels.[l].i; levels.[l].i] |> String.concat ""
        | 8 -> [levels.[l].v; levels.[l].i; levels.[l].i; levels.[l].i] |> String.concat ""
        | 9 -> [levels.[l].i; levels.[l].x] |> String.concat ""
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
