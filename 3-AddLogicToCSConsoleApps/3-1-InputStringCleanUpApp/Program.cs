Console.WriteLine("");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("--- Welcome to Tony's String-Cleaner App ---");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("");

string val = "  aBC-420_e ";
System.Console.WriteLine($"str-og:\t\t\t'{val}',\thash: {val.GetHashCode()}");
val = val.Trim();
System.Console.WriteLine($"str-trimmed:\t\t'{val}',\thash: {val.GetHashCode()}");
val = val.ToLower();
System.Console.WriteLine($"str-trimmed-lowered:\t'{val}',\thash: {val.GetHashCode()}");



Console.WriteLine("");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("--- Leaving Tony's String-Cleaner App ------");
Console.WriteLine("--------------------------------------------");
Console.WriteLine("");

