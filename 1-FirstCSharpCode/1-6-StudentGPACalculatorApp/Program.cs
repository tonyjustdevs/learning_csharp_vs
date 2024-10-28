// see https://learn.microsoft.com/en-us/training/modules/guided-project-calculate-final-gpa/2-prepare

// Project overview
// You're developing a Student GPA Calculator that will help calculate students' overall Grade Point Average. The parameters for your application are:
//    You're given the student's name and class information.
//    Each class has a name, the student's grade, and the number of credit hours for that class.
//    Your application needs to output/display the student’s name, class information, and GPA.
// Input:   [footballerName], [CourseName], [StudentGrade], [CourseCreditHours]
// Output:
// 1: [footballerName]
// 2: [Course]   [GPA]  [Credit Hours]

// To calculate the GPA:
//    Multiply the grade value for a course by the number of credit hours for that course.
//    Do this for each course, then add these results together.
//    Divide the resulting sum by the total number of credit hours.

// Sample Output
// Student: Heung Min Son

// Course           Grade   Credit Hours	
// English 101         4       3
// Algebra 101         3       3
// Biology 101         3       4
// Computer Science I  3       4
// Psychology 101      4       3

// Final GPA:          3.35


////////////////// ------- NOTE: IVE CHANGED IT TO A FOOTBALL RATING APP -------  //////////////////


// --------------------- CODE HERE --------------------- //
//[1]   Setup
using Microsoft.Win32.SafeHandles;
using System.Security.Principal;
using static System.Formats.Asn1.AsnWriter;

string footballerName = "Heung Min Son";

string skill1Name = "Dribbling 101";
string skill2Name = "Passing 101";
string skill3Name = "Pace 101";
string skill4Name = "Shooting 101";
string skill5Name = "Defending 101";

int skill1Hours = 30;
int skill2Hours = 10;
int skill3Hours = 10;
int skill4Hours = 12;
int skill5Hours = 8;

// [2]  Store the numeric grade values for each course
// [2a] Create variables to store the grade values
int ratingA = 9;
int ratingB = 8; 
int ratingC = 7; 
int ratingD = 6; 

int skill1Grade = ratingA;
int skill2Grade = ratingC;
int skill3Grade = ratingB;
int skill4Grade = ratingA;
int skill5Grade = ratingD;

// DISPLAY

int totalSkillHours = 0;

totalSkillHours += skill1Hours;
totalSkillHours += skill2Hours;
totalSkillHours += skill3Hours;
totalSkillHours += skill4Hours;
totalSkillHours += skill5Hours;

int totalSkillPoints = 0;

totalSkillPoints += skill1Hours * skill1Grade;
totalSkillPoints += skill2Hours * skill2Grade;
totalSkillPoints += skill3Hours * skill3Grade;
totalSkillPoints += skill4Hours * skill4Grade;
totalSkillPoints += skill5Hours * skill5Grade;


decimal skillPointAverage = (decimal)totalSkillPoints / totalSkillHours;

//Console.WriteLine($"{totalSkillPoints} {totalSkillHours}");
//Console.WriteLine($"{skill1Name} {skill1Grade} {skill1Hours}");
//Console.WriteLine($"{skill2Name} {skill2Grade} {skill2Hours}");
//Console.WriteLine($"{skill3Name} {skill3Grade} {skill3Hours}");
//Console.WriteLine($"{skill4Name} {skill4Grade} {skill4Hours}");
//Console.WriteLine($"{skill5Name} {skill5Grade} {skill5Hours}");
//Console.WriteLine($"Final GPA (unformatted): {skillPointAverage} ");

// One Solution (to avoid too many decimal points):
// [1] Display the first digit of the GPA,
// [2] a decimal point,
// [3] followed by the first two digits after the decimal.
// You can achieve this format by using variables to store the
// [1] leading and
// [2] trailing digits respectively, and then
// [3] printing them together using Console.WriteLine()


// [NOTICE]
// To extract the leading digit from the decimal,
// Casting [decimal result] to an [integer].
// A simple and reliable method because casting a [fractional value will never round up the result].
// Meaning if the GPA is 2.99, casting the decimal value to an int will result in 2.

int leadingDigit = (int)skillPointAverage;
int firstDigit = (int)(skillPointAverage * 10) % 10;
int secondDigit = (int)(skillPointAverage * 100) % 10;
//Console.WriteLine($"Final GPA: {leadingDigit}.{firstDigit}{secondDigit}");
// In the first half of this operation, you move the decimal one place to the right and cast it to an integer.
// In the second half, you use the remainder, or modulo, operator to get the remainder of division by 10,
// which isolates the last digit in the integer. Here's an example:

// Suppose skillPointAverage = 2.994573
// int firstDigit = (int)(2.994573 * 10) % 10;
// int firstDigit = 29 % 10;
// int firstDigit = 9;
// And the resulting value of firstDigit is 9.

//int secondDigit = (int)(2.9834 * 100) % 10;
//int secondDigit = (int)(298.34) % 10;
//int secondDigit = (298) % 10;
//int secondDigit = 8

Console.WriteLine($"Footballer: {footballerName}\n");
Console.WriteLine("Skill\t\t\t\tRating\tTraining Hours");
Console.WriteLine($"{skill1Name}\t\t\t{skill1Grade}\t{skill1Hours}");
Console.WriteLine($"{skill2Name}\t\t\t{skill2Grade}\t{skill2Hours}");
Console.WriteLine($"{skill3Name}\t\t\t{skill3Grade}\t{skill3Hours}");
Console.WriteLine($"{skill4Name}\t\t\t{skill4Grade}\t{skill4Hours}");
Console.WriteLine($"{skill5Name}\t\t\t{skill5Grade}\t{skill5Hours}");
Console.WriteLine($"\nFinal Football Rating:\t\t{leadingDigit}.{firstDigit}{secondDigit}");

