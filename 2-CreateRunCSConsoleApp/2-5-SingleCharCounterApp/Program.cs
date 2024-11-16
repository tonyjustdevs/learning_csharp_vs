Console.WriteLine("");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("--- Welcome to Tony's Fraud-Metrics App ---");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");


// 2-5-124-convert the string into a char array #125
// 2-5-124-reverse the chars array (Array.Reverse) #126
// 2-5-124-count the o's #127
// 2-5-124-convert it back to a string and print the count of o's #128


string input_str = "The quick brown fox jumps over the lazy dog.";
char[] input_array = input_str.ToArray();
Array.Reverse(input_array); //inplace operation

System.Console.WriteLine(input_array);

Console.WriteLine("");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("--- Leaving Tony's Fraud-Metrics App ------");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

