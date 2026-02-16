// A very simple constant integer
let choice = 10
// Add two integers
let higherChoice = choice + 2
// A function on integers
let f x = 2 * x * x - 5 * x + 3
// The result of a simple computation
let result = f (3 + 4)
// A Date and Time example
let myDateTime = System.DateTime(2025, 2, 3, 00, 00, 00)
// let binding on strings
let via =  "VIA
 University"
let via2 = "VIA  \
    University"
// Compute the factorial of an integer recursively
let rec factorial x =
        if x <= 1 then 
            1
        else
            x * factorial (x - 1)
// A simple pair of two integers
let pointA = (32, 42)
// A simple tuple of an integer, a string and a double-precision floating point number
let dataTuple = (1, "Tuesday",21.25)
// A function that swaps the order of two values in a tuple
let swap (a, b) = (b, a)
// The result of swapping pointA
let pointB = swap pointA
// The empty list
let listA = []
// A list with 3 integers
let aList3 = [1; 2; 3]
let newList = 0 :: aList3
// A list of first five odd integers
let oddNumbers = [1; 3; 5; 7; 9]
// A list of first five even integers
let evenNumbers = [2; 4; 6; 8; 10]
// A list with 3 integers, note head::tail constructs a list
let cList = 1 :: [2; 3]
// A list of characters
let enVowels = ['a'; 'e'; 'i'; 'o'; 'u']
// The squares of the first 10 integers in a list
let squaresOfOneToTen = [for n in 1..10 -> n*n]