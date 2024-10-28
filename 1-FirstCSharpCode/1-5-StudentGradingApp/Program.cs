// See https://learn.microsoft.com/en-us/training/modules/guided-project-calculate-print-student-grades/2-prepare

// Project overview
// Build a [Student Grading Application]:
//      calculation a [single final assignment scores] for [each student] in the class.

// The parameters of application are:
//      Given [4] students and each have [5] assignment scores.
//      [Each grade] is an integer [0-100] 
//      [Final scores] are  [average] of [5 assignment scores].

//      Application
//      - [Input:   [5] assn scores per student]
//      - [Output:  [1] final score per student] (the avg of their 5 assns)

// Given:
//      Sophia: 93, 87, 98, 95, 100
//      Nicolas: 80, 83, 82, 88, 85
//      Zahirah: 84, 96, 73, 85, 79
//      Jeong: 90, 92, 98, 100, 97

// Expected Output
// Student       Grade
// Sophia        94.6  A
// Nicolas       83.6  B
// Zahirah       83.4  B
// Jeong         95.4  A


// -------------- start code -------------- //

// [0] Setup: Given Data - initialize variables - graded assignments 
int currentAssignments = 5;

int sophia1 = 93;
int sophia2 = 87;
int sophia3 = 98;
int sophia4 = 95;
int sophia5 = 100;

int nicolas1 = 80;
int nicolas2 = 83;
int nicolas3 = 82;
int nicolas4 = 88;
int nicolas5 = 85;

int zahirah1 = 84;
int zahirah2 = 96;
int zahirah3 = 73;
int zahirah4 = 85;
int zahirah5 = 79;

int jeong1 = 90;
int jeong2 = 92;
int jeong3 = 98;
int jeong4 = 100;
int jeong5 = 97;


// see https://learn.microsoft.com/en-us/training/modules/guided-project-calculate-print-student-grades/3-exercise-store-data
// [1]      Calculate the sum of each student's assignment scores. To perform this calculation:
// [1a]    Create variables to store the sum

//int sophiaSum = 0;
//int nicolasSum = 0;
//int zahirahSum = 0;
//int jeongSum = 0;
int sophiaSum = sophia1 + sophia2 + sophia3 + sophia4 + sophia5;
int nicolasSum = nicolas1 + nicolas2 + nicolas3 + nicolas4 + nicolas5;
int zahirahSum = zahirah1 + zahirah2 + zahirah3 + zahirah4 + zahirah5;
int jeongSum = jeong1 + jeong2 + jeong3 + jeong4 + jeong5;

// [1b]    Output the sum
Console.WriteLine($"Name: Total Score (Sum All of Assignments)");
Console.WriteLine("Sophia: " + sophiaSum);
Console.WriteLine("Nicolas: " + nicolasSum);
Console.WriteLine("Zahirah: " + zahirahSum);
Console.WriteLine("Jeong: " + jeongSum);
Console.WriteLine("");
// [RESEARCH] - Although value assignment isn't required when declaring variables,
// it can make your code more efficient

// [2]      Calculate the average of the student's assignment scores
// see https://learn.microsoft.com/en-us/training/modules/guided-project-calculate-print-student-grades/4-exercise-perform-division

// [2a]     Create variables to store the average
decimal sophiaScore = sophiaSum / currentAssignments;
decimal nicolasScore = nicolasSum / currentAssignments;
decimal zahirahScore = zahirahSum / currentAssignments;
decimal jeongScore = jeongSum / currentAssignments;

Console.WriteLine($"Name: Average Score (Average of Assignments) (0 dp) = nameSum[{sophiaSum.GetType()}]/currentAssignments[{currentAssignments.GetType()}]");
Console.WriteLine("Sophia: " + sophiaScore);
Console.WriteLine("Nicolas: " + nicolasScore);
Console.WriteLine("Zahirah: " + zahirahScore);
Console.WriteLine("Jeong: " + jeongScore);
Console.WriteLine("");


// [2b]     Create (casted) variables to store the average

decimal sophiaCastedScore = (decimal)sophiaSum / currentAssignments;
decimal nicolasCastedScore = (decimal)nicolasSum / currentAssignments;
decimal zahirahCastedScore = (decimal)zahirahSum / currentAssignments;
decimal jeongCastedScore = (decimal)jeongSum / currentAssignments;

decimal sophiaCastedSum = (decimal)sophiaSum;
Console.WriteLine($"Name: Average Score (Average of Assignments) (Decimal) = nameSum[{sophiaCastedSum.GetType()}]/currentAssignments[{currentAssignments.GetType()}]");
Console.WriteLine("Sophia: " + sophiaCastedScore);
Console.WriteLine("Nicolas: " + nicolasCastedScore);
Console.WriteLine("Zahirah: " + zahirahCastedScore);
Console.WriteLine("Jeong: " + jeongCastedScore);
Console.WriteLine("");




// [2]  Add Grading Letter

Console.WriteLine($"Name: Average Score (Average of Assignments) (Decimal) and Final Grade");
Console.WriteLine("Sophia: " + sophiaCastedScore + ' ' + 'A');
Console.WriteLine("Nicolas: " + nicolasCastedScore + ' ' + 'B');
Console.WriteLine("Zahirah: " + zahirahCastedScore + ' ' + 'B');
Console.WriteLine("Jeong: " + jeongCastedScore + ' ' + 'A');
Console.WriteLine("");
Console.WriteLine("Student\tGrade (Badly Formatted)\n");
Console.WriteLine("Sophia:\t" + sophiaCastedScore + "\tA");
Console.WriteLine("Nicolas:\t" + nicolasCastedScore + "\tB");
Console.WriteLine("Zahirah:\t" + zahirahCastedScore + "\tB");
Console.WriteLine("Jeong:\t" + jeongCastedScore + "\tA");
Console.WriteLine("");

Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("--- Welcome to Tony's Student Grading Application ---");
Console.WriteLine("-----------------------------------------------------\n");
Console.WriteLine("Student\t\tGrade (Mildly Formatted)\n");
Console.WriteLine("Sophia\t\t" + sophiaCastedScore + "\tA");
Console.WriteLine("Nicolas\t\t" + nicolasCastedScore + "\tB");
Console.WriteLine("Zahirah\t\t" + zahirahCastedScore + "\tB");
Console.WriteLine("Jeong\t\t" + jeongCastedScore + "\tA");
Console.WriteLine("\n-----------------------------------------------------");
Console.WriteLine("---------------- Application Shutdown ---------------");
Console.WriteLine("-----------------------------------------------------");
Console.WriteLine("");
