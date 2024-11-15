﻿Console.WriteLine("");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("--- [Tony's Fraud-Order-Id-Generator App] ---");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("");

// Loop through each blank orderID #115
// 115-1 - Create empty array OrderIDs of length 5
// 115-2 - Loop through each orderID
// Get a random value that equates to ASCII letters A through E #116
// 116-1 - Create random instance (1 to 5)
// 116-2 - Create ASCII value: generate random val + 64
// Convert the random value into a char, then a string #117
// Create a random number, pad with zeroes #118
// Combine the prefix and suffix together, then assign to current OrderID #119
// Print out each orderID #120

Random random_ASCII_generator = new Random(); // 116-1 - Create random instance (1 to 5)

string[] OrderIDs = new string[5];
string FraudIDPrefix;
int row = 1;

foreach (string orderID in OrderIDs) // 115-1 - Loop through each blank orderID
{
  int ASCII_value = random_ASCII_generator.Next(1,5) + 64; // 116-2 - Create ASCII value: generate random val + 64
  System.Console.WriteLine(ASCII_value);
    
  System.Console.WriteLine($"{row}: {orderID}");
  row++;
}


Console.WriteLine("");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("--- [Application Ended] ---------------------");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("");

