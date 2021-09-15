using System;

namespace teckna_console_c_
{
    class Program
    {
        static void Main(string[] args)
        {
// Ändra bakgrundsfärg till mörkröd            
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.Clear();


            // Ändra textfärgen till vit
            Console.ForegroundColor = ConsoleColor.White;


            Console.WriteLine("Ett testmeddelande");   
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.WriteLine("An error has ocurred.");
            Console.WriteLine("Error: 0E : 016C : BFF415FA");
             
             
             Console.WriteLine("   /\\");
            Console.WriteLine("  /  \\");
            Console.WriteLine(" / \"\" \\");
            Console.WriteLine("/______\\");
         }
    }
}
