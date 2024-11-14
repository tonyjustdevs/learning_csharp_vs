Console.WriteLine("");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("--- [Tony's Warehouse Inventory Audit App] ---");
Console.WriteLine("-------------------------------==-------------");
Console.WriteLine("");

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
int bin = 0;

foreach (int product in inventory)
{
  bin++;
  sum += product;
  System.Console.WriteLine($"Bin {bin}: has {product} items. Running total: {sum}.");
}

System.Console.WriteLine($"Total Products: {sum}");

Console.WriteLine("");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("--- [Application Ended] ----------------------");
Console.WriteLine("----------------------------------------------");
Console.WriteLine("");

