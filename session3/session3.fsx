
// Partial function application
let add a b = a + b
let multiply a b = a * b

// Manually threads values through three functions call
let firstValue = add 5 10
let secondValue = add firstValue 7
let finalValue = multiply secondValue 2

// Pipelining
let pipelineSingleLine = 10 |> add 5 |> add 7 |> multiply 2

let pipelineMultiLine = 
    10 
    |> add 5 
    |> add 7 
    |> multiply 2

let rec sumList lst =
    match lst with
    | [] -> 0
    | hd::tl -> hd + sumList(tl)
printf "nSum of list: %d" (sumList [1..1000000])

let sumListTR ls =
    let rec sumListHelper(ls, total) =
        match ls with
        | [] -> total
        | hd::tl ->
            let ntotal = hd + total
    sumListHelper(tl, ntotal)
    sumListHelper(ls, 0)
