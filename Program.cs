using System;
class Program 
{
    static void Main()
    {
        Console.WriteLine("Welcome to 12 Tone Helper.  Would you like to generate a tone row? (y/n)");
        String input = Console.ReadLine();
        if(input == "y")
        {
            Console.WriteLine("Generating tone row...");
        } else if(input == "n") 
        {
            Console.WriteLine("goodbye!");
        }
    }
}