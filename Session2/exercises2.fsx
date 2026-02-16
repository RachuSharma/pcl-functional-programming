// 2.1.1 – Pattern matching and recursion

let vowelToUpper c =
    match c with
    | 'a' -> 'A'
    | 'e' -> 'E'
    | 'i' -> 'I'
    | 'o' -> 'O'
    | 'u' -> 'U'
    | c -> c

let rec upperVowelToString str =
    match str with
    | "" -> ""
    | str -> (vowelToUpper (str.[0])).ToString() + 
                upperVowelToString (str.[1.. String.length str - 1])

// 2.1.2 Length
let rec pmLength lst1 =
    match lst1 with
    | [] -> 0
    | (lh::lsrest) -> 1 + pmLength lsrest

//pclSum
let rec pclSum lst2 =
    match lst2 with
    | [] -> 0
    | (lh::lsrest) -> lh + pclSum lsrest

//2.1.3 List processing


let rec pmTakeSome n ls =
    match ls with
    | [] -> []
    | (lh::lsrest) when n > 0 -> lh :: pmTakeSome (n-1) lsrest
    | _ -> []






