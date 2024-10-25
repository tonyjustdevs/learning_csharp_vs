// attempt 1 to upload code to github via visual studio 
using System.Diagnostics.CodeAnalysis;
using static System.Formats.Asn1.AsnWriter;

// See https://learn.microsoft.com/en-us/training/modules/csharp-basic-formatting/5-challenge
// ----------- Goal: Print Output Location (Windows directories) in English and Russian ----------- //

// ----------- Instructions ----------- //

// The 'projectName'variable will be used twice in the desired output.
// The 'russianMessage' variable contains the message "View Russian output" in Russian.
// You must use this variable in your code that prints the message.
// You may not change these two lines of code, but you can add code above and below each line.
// You must use these two lines of code to form the desired output.
// You may only use either the Console.WriteLine() or the Console.Write() method twice.
// You can only create two instructions that actually print output to the console.
// If you need to print additional new lines or add any formatting, you must use what you've learned in this module to accomplish it.
// Use character escape sequences, verbatim strings, unicode, and string interpolation to generate the output.


// ----------- Expected Output ----------- //

// View English output:
//   c:\Exercise\ACME\data.txt
// Посмотреть русский вывод:
//   c:\Exercise\ACME\ru-RU\data.txt

// ----------- Provided Starting Code ----------- //

string projectName = "ACME";
string russianMessage = "\u041f\u043e\u0441\u043c\u043e\u0442\u0440\u0435\u0442\u044c \u0440\u0443\u0441\u0441\u043a\u0438\u0439 \u0432\u044b\u0432\u043e\u0434";