// PCL1 - Programming languages and concepts spring 2026
// Functional programming Paradigm in F#

(*
Multiline Comments
in more than one line 
*)

/// XML document for xml help documentation 

let nice = "A nice monday"

let num1= 10
let num2 = 20
//add two numbers

let addScore = num1 + num2

// a function on integers 

let f x = 2 * x* x - 5*x + 3

// result of a simple function

let result: int = f (3+4)

//Date and  Time 

let myDateTime = System.DateTime(2026,2,2,11,33,00) 

// Example: Recursion and Tuples

// A simple tuple of an integer, string, double
let dataTuple: int * string * float = (2, "Tuesday", 21.25) 


// recursive function to calculate the factorial of an integer
let rec factorial x = 
    if x <= 1 then 
        1
    else 
        x * factorial (x - 1)


// List Example 
// empty list
let emptyList = []

//list with 3 integers
let aList3 = [1; 2; 3]

//list comprehension
let squareOfOneToTen = [for n in 1..10 -> n * n]