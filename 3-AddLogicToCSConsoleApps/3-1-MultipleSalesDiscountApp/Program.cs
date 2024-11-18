Console.WriteLine("");
Console.WriteLine("----------------------------------------------------");
Console.WriteLine("--- Welcome to Tony's Mutiple-Sales-Discount App ---");
Console.WriteLine("----------------------------------------------------");
Console.WriteLine("");

//////////////// 1. PARAMS ////////////////
//// A: [TESTING PARAMS] ////
int[] sales = {600,900,1000,1200,1300};

//// B: [STATIC PARAMS] ////
int sales_minimum_for_discount_good = 1000;

//////////////// 2. METHODS ////////////////
//// A: [CONDITIONAL-OPERATOR] ////
int discount_co = sales[0] > sales_minimum_for_discount_good ? 100 : 50;
// int discount_co = sales > sales_minimum_for_discount_good ? 100 : 50;

//////////////// 3. OUTPUT ////////////////
System.Console.Write($"Sales:\t{sales[0]}\t\t");
System.Console.WriteLine($"Discount:\t{discount_co} ");

Console.WriteLine("");
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("--- Leaving Tony's Multiple-Sales-Discount App ------");
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("");

