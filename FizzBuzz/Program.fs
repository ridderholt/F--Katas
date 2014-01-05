// Learn more about F# at http://fsharp.net
// See the 'F# Tutorial' project for more help.

let fizzBuzz n = 
    match n with
    | i when i%3 = 0 && i%5 = 0 -> "FizzBuzz"
    | i when i%3 = 0 -> "Fizz"
    | i when i%5 = 0 -> "Buzz"
    | _ -> n.ToString()
      

let fizzBuzz2 n = 
    if n%3 = 0 && n%5 = 0 then
        "FizzBuzz"
    elif n%3 = 0 then
        "Fizz"
    elif n%5 = 0 then
        "Buzz"
    else
        n.ToString()

[<EntryPoint>]
let main argv = 
    let arr = [1..20]
    
    arr |> List.map fizzBuzz2 |> List.iter (fun n -> printf "%s\r\n" n)
    0 // return an integer exit code
