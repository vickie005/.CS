// using IF...else statement write a block of code to Ask the user to enter a number. If the number is positive, display: Positive Number Otherwise display: Negative Number

using System;

class Program
{
   static void Main(string[]args)
    {
        Console.Write("Enter a number: ");
        
        // Read the input and convert it to a double (handles decimals)
        double number = Convert.ToDouble(Console.ReadLine());

        // Check if the number is positive or negative
        if (number >= 0)
        {
            Console.WriteLine("Positive Number");
        }
        else
        {
            Console.WriteLine("Negative Number");
        }
    }
}