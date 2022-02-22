using System;
namespace TwelveToneHelper
{
    class Program 
    {
        static void Main()
        {
            Console.WriteLine("Welcome to 12 Tone Helper.  Would you like to generate a tone row? (y/n)");
            String input = Console.ReadLine();
            if(input == "y")
            {
                Console.WriteLine("Generating tone row...");
                ToneRow row = new ToneRow();
                Console.WriteLine($"Row equals {row.PrintRow()}"); 
            } else if(input == "n") 
            {
                Console.WriteLine("goodbye!");
            }
        }
    }
}
