Console.WriteLine("");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("--- Welcome to Tony's Detect-Fraud-Orders App ---");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("");

// Reference: https://learn.microsoft.com/en-us/training/modules/csharp-arrays/4-challenge
// Code challenge - Report the Order IDs that need further investigation
//  - Orders that start with the letter "B" encounter fraud at a rate 25 times greater than the normal rate. 
//  - You write new code that outputs the Order ID of new orders,
//  - Where the Order ID starts with the letter "B". 

// Psuedo-Plan
//  1. get order ids
//  2. convert to array
//  3. for loop
//  4.  apply String.startswith method 
//  5. output fraud ids
string[] OrderIds = {"B123","C234","A345","C15","B177","G3003","C235","B179"}; 

foreach (string OrderId in OrderIds)
{
  if (OrderId.StartsWith("B"))
  {
    System.Console.WriteLine(OrderId);
  }
  
}

Console.WriteLine("");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("--- Leaving Tony's Detect-Fraud-Orders App ------");
Console.WriteLine("-------------------------------------------------");
Console.WriteLine("");