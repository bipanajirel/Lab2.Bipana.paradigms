// For more information see https://aka.ms/fsharp-console-apps
printfn "Bipana Jirel"
// Define the Cuisine discriminated union
type Cuisine =
    | Korean
    | Turkish

// Define the MovieType discriminated union
type MovieType =
    | Regular
    | IMAX
    | DBOX
    | RegularWithSnacks
    | IMAXWithSnacks
    | DBOXWithSnacks

// Define the Activity discriminated union
type Enjoy =
    | BoardGame
    | Chill
    | Movie of MovieType
    | Restaurant of Cuisine
    | LongDrive of int * float

// Function to calculate the budget
let calcBudget (activity: Enjoy) =
    match activity with
    | BoardGame | Chill -> 0
    | Movie movieType ->
        match movieType with
        | Regular -> 12
        | IMAX -> 17
        | DBOX -> 20
        | RegularWithSnacks -> 12 + 5
        | IMAXWithSnacks -> 17 + 5
        | DBOXWithSnacks -> 20 + 5
    | Restaurant cuisine ->
        match cuisine with
        | Korean -> 70
        | Turkish -> 65
    | LongDrive (distance, fuelCostPerKm) -> int(float(distance) * fuelCostPerKm)

// Example usage
let fun1 = Movie RegularWithSnacks
let fun2 = Restaurant Korean
let fun3 = LongDrive (100, 0.1)

// Calculate the total budget
let totalBudget = calcBudget fun1 + calcBudget fun2 + calcBudget fun3

printfn "Budget for Fun 1: %d CAD" (calcBudget fun1)
printfn "Budget for Fun 2: %d CAD" (calcBudget fun2)
printfn "Budget for Fun 3: %d CAD" (calcBudget fun3)
// Print total budget
printfn "Total Budget: %d CAD" totalBudget

