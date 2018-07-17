open System

let inline random count list =
  list
  |> List.sortBy (fun _ -> Guid.NewGuid())
  |> List.truncate count


