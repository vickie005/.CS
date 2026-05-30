/*
1. Write a code that prompts the user for their name and age, and prints Hello, {name} and {age}.
2. Modify the program to reject empty input and ask again until a valid name is entered.
*/

using System;

namespace UserInput
{
    class Hello
    {
        static void Main(string[] args)
        {
            string name = "";

            // This loop keep on running until the user types a valid name
            while (true)
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();

                // If the user input isn't empty or just spaces, break out of the loop
                if (!string.IsNullOrWhiteSpace(name))
                {
                    break; 
                }

                Console.WriteLine("Name cannot be empty. Please try again.\n");
            }

            Console.Write("Enter your age: ");
            string age = Console.ReadLine();

            // Print the greeting using string interpolation
            Console.WriteLine($"\nHello, {name} and {age}!");

        }
    }
}