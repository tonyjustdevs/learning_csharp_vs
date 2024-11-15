Console.WriteLine("");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("--- [Tony's Fraud-Order-Id-Generator App] ---");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("");

// Loop through each blank orderID #115
// 115-1 - Create empty array OrderIDs of length 5
// 115-2 - Loop through each orderID
// Get a random value that equates to ASCII letters A through E #116
// 116-1 - Create random instance (1 to 5)
// 116-2 - Create ASCII value: generate random val + 64
// Convert the random value into a char, then a string #117
// Create a random number, pad with zeroes #118
// 118-1 - random value between 1-1000
// 118-2 - apply ToString Padding "000"
// 118-3 - test output
// Combine the prefix and suffix together, then assign to current OrderID #119
// 119-1 prefix + ran_val (string cat)
// 119-2 test above output
// 119-3 assign -> current orderID in loop
// Print out each orderID #120
// 121-1 test a for loop
// 121-2 apply to app
Random random_value_generator = new Random(); // 116-1 - Create random instance (1 to 5)

// string[] OrderIDs = new string[5];
string[] OrderIDs = ["5","4","3","2","1"];
string FraudIDPrefix;
int row = 1;

// int OrderIDsLength = OrderIDs.Length; // 121-1 test a for loop
// 121-2 apply to app

// System.Console.WriteLine($"OrderIDsLength: {OrderIDsLength}");
for (int i = 0; i < OrderIDs.Length; i++)
{
  // System.Console.WriteLine($"{i}");
  OrderIDs[i] = "NewString666";
}

foreach (var item in OrderIDs)
{
  System.Console.WriteLine(item);
}

foreach (string orderID in OrderIDs) // 115-1 - Loop through each blank orderID
{
  int ASCII_value = random_value_generator.Next(1,5) + 64; // 116-2 - Create ASCII value: generate random val + 64
  // System.Console.WriteLine(ASCII_value);
  // FraudIDPrefix = Convert.ToChar(65).ToString();
  FraudIDPrefix = Convert.ToChar(ASCII_value).ToString(); // 117
  // System.Console.WriteLine($"{FraudIDPrefix}");
    
  string random_str_value = random_value_generator.Next(1,1000).ToString("000"); // 8 to 008 // 118-1,2
  // string random_value = random_value_generator.Next(1,1000).ToString(""); // 8 to 8 // 118-3
  // System.Console.WriteLine($"random value with padding: {random_str_value}");
  
  // System.Console.WriteLine($"{FraudIDPrefix + random_str_value}"); //119-1,2 
  // orderID = FraudIDPrefix + random_str_value; // [# 121 bug] 119-3 assign -> current orderID in loop
  // System.Console.WriteLine($"{row}: {orderID}");
  row++;
}

Console.WriteLine("");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("--- [Application Ended] ---------------------");
Console.WriteLine("---------------------------------------------");
Console.WriteLine("");

