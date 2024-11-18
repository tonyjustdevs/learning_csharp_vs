Console.WriteLine("");
Console.WriteLine("----------------------------------------------------");
Console.WriteLine("--- Welcome to Tony's Mutiple-Sales-Discount App ---");
Console.WriteLine("----------------------------------------------------");
Console.WriteLine("");

//////////////// 1. PARAMS ////////////////
int[] sales = {600,900,1000,1001,999,1200,300,1300,2000,30};
int sales_minimum_for_discount_good = 1000;
int discount = 0;

//////////////// 2. METHODS ////////////////
foreach (int current_sales in sales)
{
  System.Console.Write($"{current_sales} - ");
  discount = current_sales > sales_minimum_for_discount_good ? 100 : 50;
  System.Console.WriteLine(discount);
} 

Console.WriteLine("");
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("--- Leaving Tony's Multiple-Sales-Discount App ------");
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("");

