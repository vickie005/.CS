Creating a new C# project:
*dotnet new console -o MyApp*

running the application:
*dotnet run*

using System; // This brings in the basic tools provided by the .NET framework.

// Every C# program needs a 'class'. Think of it as a container for your code.
class Program
{
    // The 'Main' method is the engine. When you run the app, the computer looks here first.
    static void Main(string[] args)
    {
        // --- 1. HELLO WORLD (Outputting text to the terminal) ---
        // Console.WriteLine prints text to the screen and moves to the next line.
        Console.WriteLine("Welcome to PataSpace Academy - Backend Track!");
        Console.WriteLine("---------------------------------------------");

        // --- 2. VARIABLES (Storing information in memory) ---
        // A variable is like a labeled box. We use 'string' for text, and 'int' for numbers.
        string language = "C#";
        int cohortNumber = 1;

        // We use the '+' sign to stick text and variables together (this is called concatenation).
        Console.WriteLine("You are officially in Cohort " + cohortNumber + " learning " + language + ".");

        // --- 3. USER INPUT (Making the terminal interactive) ---
        // Console.Write prints text but stays on the SAME line, waiting for you to type.
        Console.Write("\nPlease enter your name to register your environment: ");

        // Console.ReadLine() pauses the app, waits for you to type your name, and saves it in the 'studentName' variable.
        string studentName = Console.ReadLine();

        // --- 4. THE FINAL OUTPUT ---
        // Now we use the name you just typed to print a custom message.
        Console.WriteLine("\nEnvironment setup complete! Let's build, " + studentName + "!");
    }
}

=========================================================================================================

## While loop
- used to repeatedly execute a block of code as long as a condition is true
eg. 
    int i = 0;
    while i <= 5 {
        Console.WriteLine(i);
        i ++;
    }

## do- while loop
- used to execute the code at least once before checking the condition
eg.
int i = 1;
do {
    Console.WriteLine(i);
    i ++;
}
while (i <=5 );


# Control Flows
-determines how your program moves from one statement to another

