using System;
using System.Collections.Generic;

namespace QuizGame
{
    // Define the Question Blueprint
    class Question
    {
        public string QuestionText { get; set; }
        public string[] Options { get; set; }
        public int CorrectOptionIndex { get; set; } // 0-based index (0 for first option, 1 for second, etc.)

        public Question(string text, string[] options, int correctIndex)
        {
            QuestionText = text;
            Options = options;
            CorrectOptionIndex = correctIndex;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the Quiz Data
            List<Question> quizBank = new List<Question>
            {
                new Question(
                    "Which programming language is known as the 'native tongue' of Unity game development?",
                    new string[] { "Python", "C++", "C#", "Java" },
                    2 // "C#" is at index 2
                ),
                new Question(
                    "What does CLI stand for in software development?",
                    new string[] { "Command Line Interface", "Common Language Interface", "Control Line Integration", "Central Logical Internet" },
                    0 // "Command Line Interface" is at index 0
                ),
                new Question(
                    "Which keyword is used to create an instance of a class in C#?",
                    new string[] { "this", "new", "create", "make" },
                    1 // "new" is at index 1
                ),
                new Question(
                    "What is the correct way to output 'Hello World' in C#?",
                    new string[] { "print(\"Hello World\");", "Console.WriteLine(\"Hello World\");", "System.out.println(\"Hello World\");", "echo \"Hello World\";" },
                    1 // "Console.WriteLine..." is at index 1
                )
            };

            int score = 0;
            Console.WriteLine("       WELCOME TO THE TECH QUIZ GAME!       ");
            Console.WriteLine("Rules: Type the number of your answer (1-4) and press Enter.\n");

            // Loop Through Questions
            for (int i = 0; i < quizBank.Count; i++)
            {
                Console.WriteLine($"Question {i + 1}: {quizBank[i].QuestionText}");
                
                // Display the choices dynamically
                for (int j = 0; j < quizBank[i].Options.Length; j++)
                {
                    Console.WriteLine($"  {j + 1}. {quizBank[i].Options[j]}");
                }

                // Get a valid choice from the user
                int userChoice = GetValidChoice(1, quizBank[i].Options.Length);

                // Check answer (convert 1-based user choice back to 0-based index)
                if ((userChoice - 1) == quizBank[i].CorrectOptionIndex)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Correct! 🎉\n");
                    Console.ResetColor();
                    score++;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    int correctIndex = quizBank[i].CorrectOptionIndex;
                    Console.WriteLine($"Wrong! ❌ The correct answer was: {quizBank[i].Options[correctIndex]}\n");
                    Console.ResetColor();
                }
            }

            // Display Final Results
            double finalPercentage = ((double)score / quizBank.Count) * 100;

            Console.WriteLine("            ...QUIZ OVER               ");
            Console.WriteLine($"Your Score: {score} / {quizBank.Count}");
            Console.WriteLine($"Percentage: {finalPercentage:F1}%");
            Console.WriteLine("-------------------------------------");

            if (finalPercentage == 100)
            {
                Console.WriteLine("Perfect score! You're a C# rockstar! 🌟");
            }
            else if (finalPercentage >= 70)
            {
                Console.WriteLine("Great job! You know your stuff. 👍");
            }
            else
            {
                Console.WriteLine("Good attempt! Review the code and try again. 📖");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }

        
        // Helper method to ensure the user inputs a valid choice within the menu range.
      
        static int GetValidChoice(int min, int max)
        {
            int choice;
            while (true)
            {
                Console.Write($"Your Answer ({min}-{max}): ");
                string input = Console.ReadLine();

                if (int.TryParse(input, out choice) && choice >= min && choice <= max)
                {
                    return choice;
                }

                Console.WriteLine($"❌ Please enter a valid number between {min} and {max}.");
            }
        }
    }
}

