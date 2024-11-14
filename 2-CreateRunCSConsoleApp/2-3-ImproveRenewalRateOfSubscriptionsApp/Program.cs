Console.WriteLine("");
Console.WriteLine("------------------------------------------");
Console.WriteLine("--- Welcome to Tony's --------------------");
Console.WriteLine("--- Improving Renewal Rates Subs App -----");
Console.WriteLine("------------------------------------------");
Console.WriteLine("");

// Rule 1: Your code should only display one message.
// The message that your code displays will depend on the other five rules. 
// For rules 2-6, the higher numbered rules take precedence over the lower numbered rules.
// [tp: add if-else with 5 possibilities (rules 2 to 6) #77]

// Rule 2: If the user's subscription will expire in 10 days or less, display the message:
// "Your subscription will expire soon. Renew now!" #78

// Rule 3: If the user's subscription will expire in five days or less, display the messages:
// "Your subscription expires in _ days."
// "Renew now and save 10%!"

//Rule 4: If the user's subscription will expire in one day, display the messages:
// "Your subscription expires within a day!"
// "Renew now and save 20%!"


///////////////////////// code /////////////////////////

Random random = new Random();
int daysToExp = random.Next(12);
int discountPct = 0;

// daysToExp = 1;
// daysToExp = 5;
// daysToExp = 10;


if (daysToExp == 1) // rule 4:
{
  discountPct = 20;
  System.Console.WriteLine($"Your subscription expires within a day!");
  System.Console.WriteLine($"Renew now and save {discountPct}%");
} 
else if (daysToExp <= 5) // rule 3:
{
  discountPct = 10;
  System.Console.WriteLine($"Your subscription expires in {daysToExp} days.");
  System.Console.WriteLine($"Renew now and save {discountPct}%");
} 
else if (daysToExp <= 10) // rule 2:
{
  System.Console.WriteLine("Your subscription will expire soon. Renew now!");
} 


Console.WriteLine("");
Console.WriteLine("------------------------------------------");
Console.WriteLine("--- Application Ended --------------------");
Console.WriteLine("------------------------------------------");
Console.WriteLine("");

