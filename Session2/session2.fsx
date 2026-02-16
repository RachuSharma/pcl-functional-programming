// let declarations in F# 

//Abbreviated function
let square1 (x:float) = x * x

//without abbreviation 
let square = fun  x -> x * x

let classId = "IT-PCL1-S26"
classId.[7]

let pclSqr5 = square1 5

let pclsqrB = square(square(2+5))

let add (x:float) y = x + y
let funnyAdd1 = add 1

// Type inference
// takes a tuple
let makeSoftwareEngineer pclStudent = 
    let _, lastname = pclStudent
    "Software Engineer " , lastname

// factorial function
let rec factorial n =
    if n < 1 then 1
    else n * factorial (n - 1)

// pattern matching
let rec factorial_PM n =
    match n with
    | 0 | 1 -> 1
    | _ -> n * factorial_PM (n - 1)

// Tuple construction and deconstruction
// Construction 
let student1 = (25, "Alice" )
let student2 = (30,"Anna",  "No specialization")

// Deconstruction of a tuple
// Uses fst, snd pattern for deconstruction
let studentId = fst student1
let stdentName = snd student1 

let id, n, s = student2

let nameAgeCountry: string * string * int * string = "Paw", "Patrol", 9, "Plutonia"

let firstName, lastName, _ , _ = nameAgeCountry


printfn $"Name: {firstName} {lastName}"

//Lists: range, slices, indexing
let numbers = [1..10] //creates a list of integers from 1 to 10

//retrieve a range from a list: secound to the 7th item
let itemOntoSix = numbers.[1..6]

//with step
let llstWithStep = [1..3..9] // creates a list of integers from 1 to 9 with a step of 3 

//Error handling with failwith
let rec factorial_PM_PW n =
    match n with
    | 0 -> 1
    | _ -> if n > 0
            then n* factorial_PM (n - 1)
            else failwith "Negative input not allowed for factorial"

//F# follows .NET exceptions from System.Exception

let pclDiv n1 n2 =
    try
        $"The result of {n1} divided by {n2} is {n1/n2}"
    with
    | :? System.DivideByZeroException -> $"Cannot divide by zero" 
    | ex -> $"The operation failed with error: {ex.Message}"