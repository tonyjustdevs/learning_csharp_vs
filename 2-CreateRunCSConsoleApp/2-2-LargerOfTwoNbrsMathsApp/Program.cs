// See https://learn.microsoft.com/en-us/training/modules/csharp-call-methods/5-challenge

//----------------- Code challenge -----------------//
// Implement a: 
// 1. Method of Math class that 
// 2. Returns the larger of two numbers

// Output (requirement):
// Console.WriteLine(largerValue); statement to generate the output.

//----------------- BEG CODE HERE -----------------//

// 1. Input (given):
int firstValue = 500;
int secondValue = 600;
int largerValue;

// 2. Calculation:
largerValue = Math.Max(firstValue,secondValue);

// 3. Output:
Console.WriteLine(largerValue);





//----------------- END CODE HERE -----------------//

//----------------- MS Learn Example -----------------//
////////// using System.Math
////////// int xInt1 = -3;
////////// int xInt2 = 53;
////////// Console.WriteLine($"{xInt1}, {xInt2}, {Math.Max(xInt1, xInt2)}");
// ref1: https://learn.microsoft.com/en-us/dotnet/api/system.math?view=net-8.0
// ref2: https://learn.microsoft.com/en-us/dotnet/api/system.math.max?view=net-8.0#system-math-max(system-int32-system-int32)
// Math.Max | Returns Int32 | Parameter val1 or val2, whichever is larger.
//----------------- code here -----------------//
