// See https://aka.ms/new-console-template for more information


Console.WriteLine("Welcome to Tony's Die Game 🎲🎲🎲! ");

// 1. create die
// 2. roll thrice
// 3. sum total
// 4. print total

Random die = new();
int roll1 = die.Next(1,7);
int roll2 = die.Next(1,7);
int roll3 = die.Next(1,7);
int total = roll1 + roll2 + roll3;

System.Console.WriteLine($"Total = roll1 + roll2 + roll3 = {roll1} + {roll2} + {roll3} = {total}");

// #60 15+ points = win

if (total >= 15)
{
  System.Console.WriteLine("Winner winner, 🐔 dinner!");
}
