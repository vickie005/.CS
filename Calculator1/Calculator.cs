/*
 Using the different arithmetic operations, build a simple calculator where a user enters both a value and a symbol (i.e addition, subtraction, product, division sign) and gets a result of the operation. NOTE: Its a user input calculator and also makes use of any control structure taught: 'either if', 'if-else', 'while' or 'do-while loop'.
 */

using System;

class Calculator
{
    static void Main(string[]args)
    {
    
        while (true)
        {
            Console.WriteLine("--- Calculator Menu (Type 'exit' to quit) ---");
            
            Console.Write("Enter first number: ");
            string input1 = Console.ReadLine();
            if (input1.ToLower() == "exit") break;
            double num1 = Convert.ToDouble(input1);

            Console.Write("Enter symbol (+, -, *, /, %): ");
            string symbol = Console.ReadLine();

            Console.Write("Enter second number: ");
            double num2 = Convert.ToDouble(Console.ReadLine());

            // Control structure to determine the operation
            if (symbol == "+")
            {
                Console.WriteLine("Result: " + (num1 + num2));
            }
            else if (symbol == "-")
            {
                Console.WriteLine("Result: " + (num1 - num2));
            }
            else if (symbol == "*")
            {
                Console.WriteLine("Result: " + (num1 * num2));
            }
            else if (symbol == "%")
            {
                Console.WriteLine("Result: " + (num1 % num2));
            }
            else if (symbol == "/")
            {
                if (num2 == 0)
                {
                    Console.WriteLine("Error: Cannot divide by zero.");
                }
                else
                {
                    Console.WriteLine("Result: " + (num1 / num2));
                }
            }
            else
            {
                Console.WriteLine("Invalid operator symbol entered.");
            }

            Console.WriteLine(); // Blank line for spacing
        }
    }
}
