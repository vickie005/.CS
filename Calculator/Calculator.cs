// Create a simple user input calculator that can perform addition, subtraction, division and multiplication.

using System;

class Calculator
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("--- Simple Calculator ---");

        // Get the first number
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        // Get the operator
        Console.Write("Enter operator (+, -, *, /, %): ");
        string op = Console.ReadLine();

        // Get the second number
        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(); // Prints a blank line for spacing

        // Check the operator and perform the math
        if (op == "+")
        {
            Console.WriteLine("Result: " + (num1 + num2));
        }
        else if (op == "-")
        {
            Console.WriteLine("Result: " + (num1 - num2));
        }
        else if (op == "*")
        {
            Console.WriteLine("Result: " + (num1 * num2));
        }
        else if (op == "%")
        {
            Console.WriteLine("Result: " + (num1 % num2));
        }
        else if (op == "/")
        {
            // A check to make sure one doesn't divide by zero
            if (num2 == 0)
            {
                Console.WriteLine("Cannot divide by zero!");
            }
            else
            {
                Console.WriteLine("Result: " + (num1 / num2));
            }
        }
        else
        {
            Console.WriteLine("Invalid Operator!");
        }
    }
}
