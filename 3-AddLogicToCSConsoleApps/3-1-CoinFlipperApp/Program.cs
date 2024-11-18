Console.WriteLine("");
Console.WriteLine("------------------------------------------");
Console.WriteLine("--- Welcome to Tony's Coin-Flipper App ---");
Console.WriteLine("------------------------------------------");
Console.WriteLine("");
//////////////// START CODE ////////////////

// Use the Random class to generate a value. #187
//     Consider the range of numbers that is required.
// Use conditional operator to display either heads or tails. #188
//     There should be a 50% chance that the result is either heads or tails.
// refactor: to one liner inside writeline #189
//////////////// 1. PARAMS ////////////////
Random coin = new Random();

//////////////// 2. METHODS ////////////////
// int toss_value = coin.Next(0,2);

// string toss_result = (coin.Next(0,2)==1) ? "Heads 🤯!" : "Tails 🐈!";

//////////////// 3. OUTPUT ////////////////
System.Console.WriteLine((coin.Next(0,2)==1) ? "Heads 🤯!" : "Tails 🐈!");

//////////////// END CODE ////////////////

Console.WriteLine("");
Console.WriteLine("------------------------------------------");
Console.WriteLine("--- Leaving Tony's Coin-Flipper App ------");
Console.WriteLine("------------------------------------------");
Console.WriteLine("");

