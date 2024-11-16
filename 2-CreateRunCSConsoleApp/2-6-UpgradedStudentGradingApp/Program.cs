
// 2-6-134-Use arrays to store student names and assignment scores. #135
//  134-1a array student_name
//  134-1b array score
// 2-6-134-Use a foreach statement to iterate through the student names as an outer program loop. #136
//  134-2a foreach student in student_name
//  134-2b output: student
// 2-6-134-Use an if statement within the outer loop to identify the current student name and 
//          access that student's assignment scores. #137
//  134-3a add if inside loop 
//  134-3b placeholder studentscore
// 2-6-134-Use a foreach statement within the outer loop to iterate through the assignment scores array 
//          and sum the values. #138
//  134-4a foreach loop scores and sum values
// 2-6-134-Use an updated algorithm within the outer loop to calculate the average exam score for each student. #139
//  134-5a if-else for each student
//  134-5b reset to 0 for each student
// 2-6-134-Use an if-elseif-else construct within the outer loop to evaluate the average exam score 
//          and assign a letter grade automatically. #140
// 2-6-134-Integrate extra credit scores when calculating the student's final score and letter grade as follows #141
// 2-6-134-Your code must detect extra credit assignments based on the number of elements in the 
//          student's scores array. #142
// 2-6-134-Your code must apply the 10% weighting factor to extra credit assignments 
//          before adding extra credit scores to the sum of exam scores. #143

using System;

// initialize variables - graded assignments 
int currentAssignments = 5;

string[] student_names = ["oreo", "lilo", "ollie","momo"];  // 134-1a array student_name
int[] oreo_scores   = {90,86,87,98,100};                    // 134-1b array score
int[] lilo_scores   = {92,89,81,96,90};
int[] ollie_scores  = {90,85,87,98,68};
int[] momo_scores   = {90,95,87,88,96}; 

int[] current_scores = new int[5];
string current_student;

Console.WriteLine("-------------------------");
Console.WriteLine("Student\t\tGrade");
Console.WriteLine("-------------------------");

foreach (string student in student_names)                   // 134-2a foreach student in student_name
{
  int currentSum = 0;                                       // 134-5b reset to 0 for each student
  current_student = student;

  if (current_student == "oreo")                            // 134-5a if-else for each student
  {
    current_scores = oreo_scores;
  } else if (current_student == "lilo")
  {
    current_scores = lilo_scores;
  } else if (current_student == "ollie")
  {
    current_scores = ollie_scores;
  } else if (current_student == "momo")
  {
    current_scores = momo_scores;
  }

  foreach (int score in current_scores)
  {
    currentSum += score;
  }

  decimal currentScore = (decimal)currentSum / currentAssignments;

  Console.WriteLine($"{current_student}:\t\t" + currentScore + "\t?");
    
}

// Console.WriteLine("Press the Enter key to continue");
// Console.ReadLine();
