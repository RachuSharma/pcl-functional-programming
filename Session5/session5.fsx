// concurrent paradigm examples

// define a stopwatch
let stopwatch = new System.Diagnostics.Stopwatch()
let ResetStopwatch() =
    stopwatch.Reset()
    stopwatch.Start()

let ShowTime() = printfn ">>> it took %d ms " stopwatch.ElapsedMilliseconds

// Check if number is prime
let isPrimeNumber x =
    let mutable i = 2
    let mutable isFactorFound = false
    while not isFactorFound && i < x do
        if x % i = 0 then
            isFactorFound <- true
        i <- i + 1
    not isFactorFound

let intArray = [| for i in 1000000..1004000 -> i |]

ResetStopwatch()
let primeDetails1 =
    intArray
    |> Array.map (fun x -> (x, isPrimeNumber x))
ShowTime()

ResetStopwatch()
let primeDetails2 =
    intArray
    |> Array.Parallel.map (fun x -> (x, isPrimeNumber x))
ShowTime()

// Printer Agent
// MailboxProcessor example
let printerAgent =
    MailboxProcessor.Start (fun inbox ->
        // a function to process the messages in the inbox
        let rec messageLoop() =
            async {
                printfn "Waiting for message..."
                // read message
                let! message = inbox.Receive()
                // process message
                printfn "\nThe message is: %s" message 
                // loop to read next message
                return! messageLoop ()
            }
        messageLoop()
    )


let ConverterAgent =
    MailboxProcessor.Start (fun inbox ->
        // a function to process the messages in the inbox
        let rec processMessage state =
            async {
                printfn "Waiting for message..."
                // read message
                let! message = inbox.Receive()
                // process message
                printfn "\nThe message is: %A" message 
                let newState = "[" + message + "]"
                printfn "Processed message: %s" (newState.ToUpper())
                // loop to read next message
                return! processMessage newState
            }
        processMessage "initialState"
    )
let data = ["apple"; "banana"; "carrot"; "durian"; "eggplant";]
data |> List.map ConverterAgent.Post