# F# Mutable Variable Behavior in Functions

This example highlights a potential misunderstanding of mutability in F# when it comes to function calls.  The `add` function calculates the sum of `x` and `y`, but subsequent changes to `x` and `y` do not affect the already computed value of `z`.

## How to reproduce

1. Compile and run `bug.fs`.
2. Observe that the output reflects the initial values of `x` and `y` used in the `add` function, not the updated values.

## Solution

The `bugSolution.fs` file provides a corrected approach.