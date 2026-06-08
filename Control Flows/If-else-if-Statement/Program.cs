// using IF...else...IF statement write a block of code to Ask the user to enter marks. Marks Grade 90-100 A 80-89 B 70-79 C 60-69 D Below 60 E

using System;

class Program
{
   static void Main(string[]args)
    {
       Console.Write("Enter marks: ");
       int marks = int.Parse(Console.ReadLine());

       if (marks >= 90)
        {
            Console.WriteLine("Grade A");
        } 
        else if (marks >= 80)
        {
            Console.WriteLine("Grade B");
        }
        else if (marks >= 70)
        {
            Console.WriteLine("Grade C");
        }
        else if (marks >= 60)
        {
            Console.WriteLine("Grade D");
        }
        else
        {
            Console.WriteLine("Grade E");
        }
    }
}