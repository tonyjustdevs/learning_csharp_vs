
using System.Threading;

Random dice = new Random();
// int roll = dice.Next(1, 7);
int roll = dice.Next(1, 3);
string outcome;

if (roll == 2)
{
  outcome = "die!] haha 💀";
} else
{
  outcome = "live], congrats 🏆!";
}
Console.WriteLine("");
Console.WriteLine("----------------------------------");
Console.WriteLine("--- Welcome to Tony's Die Game ---");
Console.WriteLine("----------------------------------");
Console.Write("--- A die is rolling");
Console.Write("🎲");
Thread.Sleep(500);
Console.Write("🎲");
Thread.Sleep(500);  
Console.Write("🎲");
Thread.Sleep(500);
Console.WriteLine("");
// Console.WriteLine($"--- Its a {roll}!");
Console.WriteLine($"--- [You {outcome}");
Thread.Sleep(500);
Console.WriteLine("--- Hope you had fun 🎃");
Thread.Sleep(500);
Console.WriteLine("--- Good-bye 🦇!");
Thread.Sleep(500);
Console.WriteLine("-----------------------------------\n");