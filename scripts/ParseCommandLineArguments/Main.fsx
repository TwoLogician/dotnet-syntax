let orderByName = "N"
let orderBySize = "S"

type CommandLineOptions = { 
    Verbose: bool
    Subdirectories: bool
    OrderBy: string
}

let rec parseCommandLine args optionsSofar = 
    match args with
    | [] ->
        optionsSofar
    | "/v" :: xs ->
        let newOptions = { optionsSofar with Verbose = true }
        parseCommandLine xs newOptions
    | "/s" :: xs ->
        let newOptions = { optionsSofar with Subdirectories = true }
        parseCommandLine xs newOptions
    | "/o" :: xs ->
        match xs with
        | "S" :: xss ->
            let newOptions = { optionsSofar with OrderBy = orderBySize}
            parseCommandLine xss newOptions 
        | "N" :: xss ->
            let newOptions = { optionsSofar with OrderBy = orderByName}
            parseCommandLine xss newOptions 
        | _ ->
            eprintfn "OrderBy needs a second argument"
            parseCommandLine xs optionsSofar 
    | x :: xs ->
        eprintfn "Option %s is unrecognized" x
        parseCommandLine xs optionsSofar

let options = parseCommandLine ["/v"; "/s"; "/o"; "N"] { Verbose = false; Subdirectories = false; OrderBy = orderByName }

options |> printfn "%A"