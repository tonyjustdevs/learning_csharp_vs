Console.WriteLine("");
Console.WriteLine("------------------------------------------");
Console.WriteLine("--- Welcome to Tony's --------------------");
Console.WriteLine("--- Improving Renewal Rates Subs App -----");
Console.WriteLine("------------------------------------------");
Console.WriteLine("");


Random random = new Random();
int daysToExp = random.Next(12);
int discountPct = 0;

// Rule 1: Your code should only display one message.
// The message that your code displays will depend on the other five rules. 
// For rules 2-6, the higher numbered rules take precedence over the lower numbered rules.
// [tp: add if-else with 5 possibilities (rules 2 to 6) #77]

// Rule 2: If the user's subscription will expire in 10 days or less, display the message:
// "Your subscription will expire soon. Renew now!" #78


if (daysToExp <= 10) // rule 2:
{
  System.Console.WriteLine("Your subscription will expire soon. Renew now!");
} else if (true) // rule 3:
{
  System.Console.WriteLine($"3");
} else if (true) // rule 4:
{
  System.Console.WriteLine($"4");
  
} else if (true) // rule 5:
{
  System.Console.WriteLine($"5");
  
} else // rule 6:
{
  System.Console.WriteLine($"6");
}


Console.WriteLine("");
Console.WriteLine("------------------------------------------");
Console.WriteLine("--- Application Ended --------------------");
Console.WriteLine("------------------------------------------");
Console.WriteLine("");

