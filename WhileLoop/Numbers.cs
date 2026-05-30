// Using the While Loop structure, write a block of code to output a list of 10 numbers from 0-10.


using System;
class Numbers
{
    static void Main(string[] args)
    {

        int counter = 0;

        Console.WriteLine("Listing numbers from 0 to 10:");

        while (counter <= 10)
        {
            Console.WriteLine(counter);
            counter++; // Increases the counter by 1 each loop
        }
    }
}