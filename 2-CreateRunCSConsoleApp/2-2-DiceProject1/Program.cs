
using System.Threading;
System.Console.WriteLine("...two dice are rollin...");

Random dice1_object = new Random();   // old way
Random dice2_object = new();          // new way

int dice1_roll_value = dice1_object.Next(1,7);
int dice2_roll_value = dice2_object.Next(1,7);

System.Console.WriteLine($"die1_roll: {dice1_roll_value}");
System.Console.WriteLine($"die2_roll: {dice2_roll_value}");