// #Regression #NoMono #NoMT #CodeGen #EmittedIL 
// Regression test for FSHARP1.0:5646

let squaresOfOneToTenC() = [ for x in 0 .. 10 -> x * x ]

