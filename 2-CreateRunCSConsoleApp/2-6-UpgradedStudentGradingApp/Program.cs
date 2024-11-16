
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
// 2-6-134-Use an updated algorithm within the outer loop to calculate the average exam score for each student. #139
// 2-6-134-Use an if-elseif-else construct within the outer loop to evaluate the average exam score 
//          and assign a letter grade automatically. #140
// 2-6-134-Integrate extra credit scores when calculating the student's final score and letter grade as follows #141
// 2-6-134-Your code must detect extra credit assignments based on the number of elements in the 
//          student's scores array. #142
// 2-6-134-Your code must apply the 10% weighting factor to extra credit assignments 
//          before adding extra credit scores to the sum of exam scores. #143

using System;

// initialize variables - graded assignments 
// int currentAssignments = 5;

string[] student_names = ["oreo", "lilo", "ollie","momo"];  // 134-1a array student_name
int[] oreo_scores   = {90,86,87,98,100};                    // 134-1b array score
int[] lilo_scores   = {92,89,81,96,90};
int[] ollie_scores  = {90,85,87,98,68};
int[] momo_scores   = {90,95,87,88,96}; 

foreach (string student in student_names)                   // 134-2a foreach student in student_name
{
  System.Console.WriteLine($"Student: {student}");          // 134-2b output: student
  if (student == "oreo")                                    // 134-3a add if inside loop 
  {                                                         // 134-3b placeholder studentscore                          
    // oreo_scores              
  }

  if (student == "lilo")
  {
    // lilo_scores;
  }

  if (student == "ollie")
  {
    // ollie_scores;
  }

  if (student == "momo")
  {
    // momo_scores;
  }
  
}


// int oreoSum = 0;
// int liloSum = 0;
// int ollieSum = 0;
// int momoSum = 0;

// decimal oreoScore;
// decimal liloScore;
// decimal ollieScore;
// decimal momoScore;

// oreoSum = oreo1 + oreo2 + oreo3 + oreo4 + oreo5;
// liloSum = lilo1 + lilo2 + lilo3 + lilo4 + lilo5;
// ollieSum = ollie1 + ollie2 + ollie3 + ollie4 + ollie5;
// momoSum = momo1 + momo2 + momo3 + momo4 + momo5;

// oreoScore = (decimal)oreoSum / currentAssignments;
// liloScore = (decimal)liloSum / currentAssignments;
// ollieScore = (decimal)ollieSum / currentAssignments;
// momoScore = (decimal)momoSum / currentAssignments;

// Console.WriteLine("Student\t\tGrade\n");
// Console.WriteLine("oreo:\t\t" + oreoScore + "\tA-");
// Console.WriteLine("lilo:\t\t" + liloScore + "\tB+");
// Console.WriteLine("ollie:\t\t" + ollieScore + "\tB");
// Console.WriteLine("momo:\t\t" + momoScore + "\tA-");

// Console.WriteLine("Press the Enter key to continue");
// Console.ReadLine();
