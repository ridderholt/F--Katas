namespace FizzBuzz
type FizzBuzz() =
    member this.Calculate (n:int) = 
        match n with
        | i when i%3 = 0 && i%5 = 0 -> "FizzBuzz"
        | i when i%3 = 0 -> "Fizz"
        | i when i%5 = 0 -> "Buzz"
        | _ -> n.ToString()

    member this.Calculate2 (n:int) =  
        if n%3 = 0 && n%5 = 0 then
            "FizzBuzz"
        elif n%3 = 0 then
            "Fizz"
        elif n%5 = 0 then
            "Buzz"
        else
            n.ToString()
