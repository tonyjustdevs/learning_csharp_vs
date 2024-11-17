
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
//  134-6a add extra credit assignments
//  Extra Credit Scores @ 10% per assignment:
//    Sophia: 94, 90
//    Andrew: 89
//    Emma: 89, 89, 89
//    Logan: 96
// 2-6-134-Your code must detect extra credit assignments based on the number of elements in the 
//          student's scores array. #142
// 2-6-134-Your code must apply the 10% weighting factor to extra credit assignments 
//          before adding extra credit scores to the sum of exam scores. #143
// 2-6-134-add: extra students names and scores and verify output #144
// 2-6-134-refactor: for-loop to for-each of scores calculation #145
using System;

// initialize variables - graded assignments 
int nbrCurrentAssignments = 5;

string[] student_names = ["oreo", "lilo", "ollie","momo"];  // 134-1a array student_name
string[] add_celebs_names = {"messi", "iniest", "jurgen", "pep"};

student_names = student_names.Concat(add_celebs_names).ToArray(); //144
System.Console.WriteLine(student_names);
// string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
// int[] oreo_scores   = {90,86,87,98,100};                    // 134-1b array score
// int[] lilo_scores   = {92,89,81,96,90};
// int[] ollie_scores  = {90,85,87,98,68};
// int[] momo_scores   = {90,95,87,88,96}; 

int[] oreo_scores   = {90,86,87,98,100,94,90};      // 134-6a add extra credit assns
int[] lilo_scores   = {92,89,81,96,90,89};
int[] ollie_scores  = {90,85,87,98,68,89,89,89};
int[] momo_scores   = {90,95,87,88,96,96}; 

// int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
// int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
// int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
// int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] messi_scores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] iniesta_scores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] jurgen_scores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] pep_scores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    


int[] current_scores = new int[5];
string current_student;

Console.WriteLine("-------------------------------------------");
Console.WriteLine("Student\t\tMark\tGrade\tAssignments");
Console.WriteLine("-------------------------------------------");

foreach (string student in student_names)                   // 134-2a foreach student in student_name
{
  // int currentSum = 0;                                       // 134-5b reset to 0 for each student
  decimal currentSum = 0;                                       // 134-5b reset to 0 for each student
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
  } else if (current_student == "messi")
  {
    current_scores = messi_scores;
  } else if (current_student == "iniesta")
  {
    current_scores = iniesta_scores;
  } else if (current_student == "jurgen")
  {
    current_scores = jurgen_scores;
  } else if (current_student == "pep")
  {
    current_scores = pep_scores;
  }

  decimal sum_credit_score = 0;
  int extra_credit_counter = 0;
  for (int i = 0; i < current_scores.Length; i++) //0-score_leng
  {
    if (i<nbrCurrentAssignments) //0-4
    {
      currentSum += current_scores[i]; // score is as i, or 100%
    }
    else
    {
      // extra_credit_counter++;
      currentSum += current_scores[i]/10; // any score after first 5 is worth 10%
    }
  }
  // System.Console.WriteLine($"extra credit: {sum_credit_score} counter: {extra_credit_counter}");
  // decimal currentScore = (decimal)(currentSum+sum_credit_score)/(nbrCurrentAssignments+extra_credit_counter);
  decimal currentScore = (decimal)currentSum / nbrCurrentAssignments; // calc over first 5 assn
  // currentScore += (decimal)sum_credit`_score/extra_credit_counter; // add extra extra;

// 97 - 100   A+
// 93 - 96    A
// 90 - 92    A-
// 87 - 89    B+
// 83 - 86    B
// 80 - 82    B-
// 77 - 79    C+
// 73 - 76    C
// 70 - 72    C-
// 67 - 69    D+
// 63 - 66    D
// 60 - 62    D-
// 0  - 59    F
  string currentGrade;

  if (currentScore >= 97)
  {
    currentGrade = "A+";
  } else if (currentScore >= 93)
  {
    currentGrade = "A";
  } else if (currentScore >= 90)
  {
    currentGrade = "A-";
  } else if (currentScore >= 87)
  {
    currentGrade = "B+";
  } else if (currentScore >= 83)
  {
    currentGrade = "B";
  } else if (currentScore >= 80)
  {
    currentGrade = "B-";
  } else if (currentScore >= 77)
  {
    currentGrade = "C+";
  } else if (currentScore >= 73)
  {
    currentGrade = "C";
  } else if (currentScore >= 70)
  {
    currentGrade = "C-";
  } else if (currentScore >= 67)
  {
    currentGrade = "D+";
  } else if (currentScore >= 63)
  {
    currentGrade = "D";
  } else if (currentScore >= 60)
  {
    currentGrade = "D-";
  } else
  {
    currentGrade = "F";
  }

  
  Console.WriteLine($"{current_student}:\t\t{currentScore}\t{currentGrade}\t{current_scores.Length}");
    
}

// Console.WriteLine("Press the Enter key to continue");
// Console.ReadLine();

