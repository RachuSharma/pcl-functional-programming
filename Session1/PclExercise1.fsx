// 1.2.1 –Create F# Script

let x = 23
let myName = "Rachana"
let age = 27
let country = "Nepal"
let y = 6 + 6


let a = 5
let b = let a = 10 in a + 5

let c = a + b


// 1.2.2 – Function Declaration

let addNum1 n = n + 1
//let addNum10 (n: int) = n + 10

//let addNum20 n= addNum10 (addNum10 n)

//1.2.3 – Function Declaration
let max2 w  y =
    if w > y then w 
    else y


let evenOrOdd n =
    if n % 2 = 0 then "Even Number"
    else "Odd Number"

    
let addXY x y =
    printfn "x = %d, y = %d" x y
    printfn "sum = %d " (x + y)

    
// 1.2.4 – Function Declaration

let addNum10 (n: int) = n + 10
let rec addNum_jk j k = 
    if k = 0 then j
    else addNum10 (addNum_jk j (k - 1))