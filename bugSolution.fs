let mutable x = 10
let mutable y = 20

let add () = x + y //Now add is a function that returns the sum of the current values of x and y

let z = add ()
printf "%d" z

x <- 15
y <- 25

let z2 = add ()
printf "%d %d %d" x y z2