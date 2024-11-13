﻿// See https://aka.ms/new-console-template for more information


Console.WriteLine("Welcome to Tony's Die Game 🎲🎲🎲! ");

// 1. create die
// 2. roll thrice
// 3. sum total
// 4. print total

Random die = new();
int roll1 = die.Next(1,7);
int roll2 = die.Next(1,7);
int roll3 = die.Next(1,7);

roll1=10;
roll2=10;
// roll3=10;
int total = roll1 + roll2 + roll3;

System.Console.WriteLine($"Total = roll1 + roll2 + roll3 = {roll1} + {roll2} + {roll3} = {total}");

if (roll1 == roll2 || roll1 == roll3 || roll2 == roll3)
{
  total += 2; // #62
  System.Console.WriteLine("Double trouble! Bonus 2 points!");
}

if (roll1 == roll2 && roll2 == roll3)
{
  total += 6; // #63
  System.Console.WriteLine("You be trippin! Bonus 6 points!");
}

if (total >= 15) // #60 15+ points = win
{
  System.Console.WriteLine($"Winner winner, 🐔 dinner! ({total} points)");
}

if (total < 15) // #61 <15 points = lose
{
  System.Console.WriteLine($"You lost, please try again! 👎 ({total} points)");
}
