using System;

namespace BOOP_02_07
{
    class Program
    {
        static void Main(string[] args)
        {
            //Assignment immutable Reference Type (string) behaves like a value type
            string string_a = "text1";
            string string_b = "text2";

            string_b = string_a;  //as it is immutable, a copy of string_a is assign to string_b
            string_a = "text3";

            Console.WriteLine($"string_a: {string_a}"); // text3
            Console.WriteLine($"string_b: {string_b}"); // text1
            Console.WriteLine();
        }
    }
}
