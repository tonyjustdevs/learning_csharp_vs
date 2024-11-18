Console.WriteLine("");
Console.WriteLine("-------------------------------------");
Console.WriteLine("--- Welcome to Tony's Boolean App ---");
Console.WriteLine("-------------------------------------");
Console.WriteLine("");

// test !(a==b) vs a!=b

int a=1;
int b=1;
int c=2;
bool test1 = (a==b);    // T 
bool test2 = !(a==b);   // F
bool test3 = (a!=b);    // F
 
bool test4 = (a==c);    // F
bool test5 = !(a==c);   // T
bool test6 = (a!=c);    // T

System.Console.WriteLine($"{test1}");
System.Console.WriteLine($"{test2}");
System.Console.WriteLine($"{test3}");

System.Console.WriteLine($"{test4}");
System.Console.WriteLine($"{test5}");
System.Console.WriteLine($"{test6}");

Console.WriteLine("");
Console.WriteLine("-------------------------------------");
Console.WriteLine("--- Leaving Tony's Boolean App ------");
Console.WriteLine("-------------------------------------");
Console.WriteLine("");

