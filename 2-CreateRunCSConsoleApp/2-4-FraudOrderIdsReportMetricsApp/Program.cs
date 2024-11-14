Console.WriteLine("");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("--- Welcome to Tony's Fraud-Metrics App ---");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

// #99  eg report: First: "A420" etc
// #100 eg report: Reassigned First: "A999" etc
// #101 eg report: Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");
string[] FraudulentOrderIds = ["ManCity115","Arsenal2nd","Liverpool3rd"];

System.Console.WriteLine($"First: {FraudulentOrderIds[0]}");
System.Console.WriteLine($"Second: {FraudulentOrderIds[1]}");
System.Console.WriteLine($"Third: {FraudulentOrderIds[2]}");

FraudulentOrderIds[0] = "TottenhamAnge2ndYear";
System.Console.WriteLine($"Re-assigned First: {FraudulentOrderIds[0]}");

Console.WriteLine("");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("--- Leaving Tony's Fraud-Metrics App ------");
Console.WriteLine("-------------------------------------------");
Console.WriteLine("");

