using System;

namespace BOOP_02_13
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your first name?");
            string firstname = Console.ReadLine();

            Console.WriteLine($"{firstname}, please press a key. (Q or q to quit)");

            ConsoleKeyInfo key;
            do
            {
                key = Console.ReadKey();

                Console.WriteLine();
                Console.Write($"You pressed the key {key.Key}");
                if (key.Modifiers != 0) 
                    Console.WriteLine($" with the modifiers {key.Modifiers}");
                else 
                    Console.WriteLine();

                Console.WriteLine($"The character {key.KeyChar} hexadecimal value is 0x{(ushort)key.KeyChar:x4}.");

            } while (key.Key != ConsoleKey.Q);

            Console.WriteLine();
            Console.WriteLine("Thanks for playing");
        }
    }
}
