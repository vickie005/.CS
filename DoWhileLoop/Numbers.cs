/*
Using the do-while loop structure, write a block of code to allow user enter a number and print a list of numbers. NOTE:User input.. and list of numbers should maximize at 5.
*/

using System;
class Numbers
{
    static void Main(string[] args)
    {

        Console.Write("Enter a starting number: ");
        int startNum = Convert.ToInt32(Console.ReadLine());

        int itemsPrinted = 0;

        Console.WriteLine("\nGenerating your list (Max 5 items):");

        do
        {
            Console.WriteLine(startNum);
            startNum++;      // Moves to the next number
            itemsPrinted++;  // Keeps track of how many numbers you've printed
            
        } while (itemsPrinted < 5); // Forces the loop to stop exactly at 5 iterations
    }
}