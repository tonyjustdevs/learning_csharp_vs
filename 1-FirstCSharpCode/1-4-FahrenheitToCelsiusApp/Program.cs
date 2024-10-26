// https://learn.microsoft.com/en-us/training/modules/csharp-basic-operations/5-challenge
// Code Challenge: Write to convert temperatures in degrees Fahrenheit to Celsius,
// 1. first subtract 32,
// 2. then multiply by five ninths (5 / 9).
// 3. Output: The temperature is 34.4 Celsius.  

// Reference:
// Print Variable (1 d.p.) [Method 1]: cdubz($"{variable:F1}")

//------------- Start Code ------------- //

int fahrenheit = 94;
//decimal celcius = (decimal)(fahrenheit - 32) * (decimal)(5.0m / 9.0m); // OK
//decimal celcius = (decimal)(fahrenheit - 32) * (decimal)(5.0 / 9.0);   // OK
//decimal celcius = (decimal)(fahrenheit - 32) * (decimal)(5m / 9m);     // OK
//decimal celcius = (fahrenheit - 32) * (decimal)(5m / 9m);                // OK as hard-coded 94 only
decimal celcius = (fahrenheit - 32m) * (decimal)(5m / 9m);                // OK but apparently good practice

Console.WriteLine($"The temperature is {celcius:F1} Celsius.");