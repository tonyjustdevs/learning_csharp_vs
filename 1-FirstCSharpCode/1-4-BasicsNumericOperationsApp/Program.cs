// See https://github.com/tonyjustdevs/learning_csharp_vs/issues/10

// **Add two numeric values**: To add two numbers together, use the **addition operator*, the **plus** symbol `*`.
int firstNbr = 69;
int secondNbr = 420;
Console.WriteLine($"Did you know [{firstNbr}] S+ [{secondNbr}] = [{firstNbr+ secondNbr}]");

//**Mix data types to force implicit type conversions**
string firstName = "Tony";
string bakeryGood = "donuses";
int bakeryGoodQtySold = 666;

Console.WriteLine(firstName + " sold " + bakeryGoodQtySold + " " + bakeryGood);
Console.WriteLine(firstName + " ate " + (bakeryGoodQtySold + 222)+ " " + bakeryGood);
// **overloaded operator**: The parentheses symbol `()` form the order of operations operator.
// **decimal versus literal integer data**: `int` cannot contain values after the decimal.

int integer1 = 1;
int integer2 = 2;
int quotientResultInteger = integer1 + integer2;

//decimal decimalValue = 1.0;  // Error: 1.0 default type is 'double' cant -> decimal
decimal decimal1 = 6.9m;
decimal decimal2 = 4.20m;
decimal quotientDecimalValue = decimal1 / decimal2;
Console.WriteLine(quotientDecimalValue);

//**cast results of integer division**: cast integers to decimal 
int castInteger1 = 37, castInteger2 = 73;
decimal castIntegerSumValue = (decimal)castInteger1 + (decimal)castInteger2;

Console.WriteLine($"{castIntegerSumValue} is type {castIntegerSumValue.GetType()} " +
    $"= (decimal){castInteger1}[type:{castInteger1.GetType()}] + (decimal){castInteger2}[type:{castInteger2.GetType()}]");
Console.WriteLine($"((decimal)castInteger1).GetType(): {((decimal)castInteger1).GetType()}");

//**calculate remainder after integer division**: modulus operator `%` calculates remainder of `int` division

Console.WriteLine($"[10 % 5] has as a remainder of [{10 % 5}]");
Console.WriteLine($"[9 % 2] has as a remainder of [{9 % 2}]");
Console.WriteLine($"[12 % 10] has as a remainder of [{12 % 10}]");

//**Increment and decrement**: 
int value_to_increment = 2;
int increment_value = 10;
//value_to_increment += increment_value;

Console.WriteLine($"value_to_increment [{value_to_increment += increment_value}] = {value_to_increment} += {increment_value} = ");
Console.WriteLine($"value_to_increment [{value_to_increment += increment_value}] = {value_to_increment} += {increment_value} = ");
Console.WriteLine($"value_to_increment [{value_to_increment += increment_value}] = {value_to_increment} += {increment_value} = ");

int val = 5;
Console.WriteLine($"val++ = {val++}, expected: [5]");  // [5] -> 6
Console.WriteLine($"val = {val}, expected: [6]");      // [6]
Console.WriteLine($"val++ = {val++}, expected: [6]");  // [6] -> 7
Console.WriteLine($"++val = {++val}, expected: [8]");  // [8] 
Console.WriteLine($"val = {val}, expected: [8]");      // [8]



















