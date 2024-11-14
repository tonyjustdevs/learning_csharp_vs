Console.WriteLine("");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("--- [Tony's Warehouse Inventory Audit App] ---");
Console.WriteLine("-------------------------------==-------------");
Console.WriteLine("");

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;


foreach (int product in inventory)
{
  // System.Console.WriteLine(product);
  sum += product;
}
System.Console.WriteLine($"Total Products: {sum}");

Console.WriteLine("");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("--- [Application Ended] ----------------------");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("");

