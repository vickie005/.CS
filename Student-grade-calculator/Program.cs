// Student Grade Calculator CLI
// This program calculates a student's final grade based on their assignment, exam, and attendance scores.


using System;

namespace GradeCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("    STUDENT GRADE CALCULATOR CLI     ");

            // Gather User Input for Student's Name and Scores
            Console.Write("Enter Student's Name: ");
            string studentName = Console.ReadLine();

            // Input with simple validation loops to ensure scores are between 0 and 100
            double assignmentScore = GetValidScore("Assignments (0-100): ");
            double examScore = GetValidScore("Exams (0-100): ");
            double attendanceScore = GetValidScore("Attendance (0-100): ");

            // Calculate Weighted Final Score 
            // Weights: Assignments = 20%, Exams = 70%, Attendance = 10%
            double finalScore = (assignmentScore * 0.20) + (examScore * 0.70) + (attendanceScore * 0.10);

            // Determine Letter Grade and Feedback based on Final Score
            string letterGrade;
            string feedback;

            if (finalScore >= 90)
            {
                letterGrade = "A";
                feedback = "Excellent work! Keep it up.";
            }
            else if (finalScore >= 80)
            {
                letterGrade = "B";
                feedback = "Great job! Very solid performance.";
            }
            else if (finalScore >= 70)
            {
                letterGrade = "C";
                feedback = "Good effort, but there is room for improvement.";
            }
            else if (finalScore >= 60)
            {
                letterGrade = "D";
                feedback = "Passed, but needs significant improvement.";
            }
            else
            {
                letterGrade = "F";
                feedback = "Failed. Please seek academic assistance.";
            }

            // Display the Report Card with Final Score, Letter Grade, and Feedback
            Console.WriteLine("            REPORT CARD:              ");
            Console.WriteLine($"Student Name     : {studentName}");
            Console.WriteLine($"Assignment Avg   : {assignmentScore:F2}% (Weight: 20%)");
            Console.WriteLine($"Exam Avg         : {examScore:F2}% (Weight: 70%)");
            Console.WriteLine($"Attendance Avg   : {attendanceScore:F2}% (Weight: 10%)");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"FINAL SCORE      : {finalScore:F2}%");
            Console.WriteLine($"LETTER GRADE     : {letterGrade}");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine($"Feedback: {feedback}");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        /// Helper method to ensure the user inputs a valid number between 0 and 100.
        static double GetValidScore(string prompt)
        {
            double score;
            while (true)
            {
                Console.Write(prompt);
                string input = Console.ReadLine();

                // Check if input is a valid double and falls within the 0-100 range
                if (double.TryParse(input, out score) && score >= 0 && score <= 100)
                {
                    return score;
                }

                Console.WriteLine("❌ Invalid input. Please enter a number between 0 and 100.");
            }
        }
    }
}


// Key C# Concepts Used:
// double.TryParse(): Used inside the GetValidScore helper function. It safely converts a string to a number without crashing the program if the user accidentally types letters.

// String Interpolation ($"{variable}"): A clean way to insert variables directly into text strings.

// Formatting (:F2): Tells C# to display the double values rounded to exactly 2 decimal places.