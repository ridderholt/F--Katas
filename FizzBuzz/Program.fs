open FizzBuzz

[<EntryPoint>]
let main argv = 
    let arr = [1..20]
    let fizz = FizzBuzz()
    
    arr |> List.map fizz.Calculate |> List.iter (fun n -> printf "%s\r\n" n)
    0 // return an integer exit code
