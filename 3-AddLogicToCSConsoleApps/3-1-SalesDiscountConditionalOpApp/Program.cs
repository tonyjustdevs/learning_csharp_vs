Console.WriteLine("");
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("--- Welcome to Tony's Single-Sales-Discount App ---");
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("");
// [Determine Discount Based on Sales Value]
// [Test Two Methods]
// [if-else vs conditional-operation]
// [business logic]: sales > 1000, discount 100, otherwise 50

//////////////// 1. PARAMS ////////////////
//// A: [TESTING PARAMS] ////
int sales = 1000;         // okay
// int sales = 1001;         // good

//// B: [STATIC PARAMS] ////
int discount_good = 100;
int discount_okay = 50;
int discount = 0; 
int sales_minimum_for_discount_good = 1000;

//////////////// 2. METHODS ////////////////
//// A: [IF-ELSE METHOD] ////
if (sales > sales_minimum_for_discount_good)
{
  discount = discount_good;
}
else
{
  discount = discount_okay;
}
//// B: [CONDITIONAL-OPERATOR] ////
int discount_co = sales > sales_minimum_for_discount_good ? 99 : 49;

//////////////// 3. OUTPUT ////////////////
System.Console.Write($"Sales-og:\t{sales}\t\t");
System.Console.WriteLine($"Discount-og:\t{discount} ");

System.Console.Write($"Sales-co:\t{sales}\t\t");
System.Console.WriteLine($"Discount-co:\t{discount_co} ");

Console.WriteLine("");
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("--- Leaving Tony's Single-Sales-Discount App ------");
Console.WriteLine("---------------------------------------------------");
Console.WriteLine("");

