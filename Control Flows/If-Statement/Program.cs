// using IF statement write a block of code to Ask the user to enter their salary. If the salary is greater than 50,000, display: You qualify for a bonus.
using System;

class Program
{
   static void Main(string[]args)
    {
        Console.Write("what is your salary? : ");
        float salary = float.Parse(Console.ReadLine()); // parse converts the user input to the specified datatype (float)
    
       if (salary > 50000)
        {
            Console.WriteLine("You qualify for a bonus");
        }


    }
}