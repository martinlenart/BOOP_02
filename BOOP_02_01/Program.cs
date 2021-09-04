using System;

namespace BOOP_02_01
{
    class Program
    {
        // Value type 
        public struct structPoint
        {
            public int X, Y;        // data members
        }

        // Reference type
        public class classPoint
        {
            public int X, Y;        // data members
        }

        static void Main(string[] args)
        {
            // Simple Value types
            int x = 1;
            int y = 2;

            // Equality based on value
            Console.WriteLine(x == y);      // False
            Console.WriteLine(x != y);      // True
            Console.WriteLine(x < y);       // True
            Console.WriteLine(x >= y);      // False

            // Custom Value type
            var sPoint1 = new structPoint { X = 0, Y = 0 };
            var sPoint2 = new structPoint { X = 0, Y = 0 };
            // Console.WriteLine(sPoint1 == sPoint2);               // Compiler error because unknown how to compare equality
            Console.WriteLine(sPoint1.X == sPoint2.X);              // True

            // Custom Reference type, equality, by default, is based on reference
            var cPoint1 = new classPoint { X = 0, Y = 0 };
            var cPoint2 = new classPoint { X = 0, Y = 0 };
            var cPoint3 = cPoint2;
            Console.WriteLine(cPoint1 == cPoint2);                  // False - they refer to different instances
            Console.WriteLine(cPoint2 == cPoint3);                  // True - they refer to same instance
            Console.WriteLine(cPoint1.X == cPoint2.X);              // True - equality based on value

            // The && and || operators and & and | test for and and or conditions. 
            cPoint3 = new classPoint { X = 10, Y = 10 };
            //cPoint3 = null;

            // &&, || short circuit
            if (cPoint3 != null && cPoint3.X > 0)
                Console.WriteLine("cPoint3.X is > 0");
            else
                Console.WriteLine("cPoint3 is null");

            // &, | do not short cicuit and whole expression is evaluated
            if (cPoint3 != null & cPoint3.X > 0)                    // Exception is thrown when cPoint3 == null
                Console.WriteLine("cPoint3.X is > 0");
            else
                Console.WriteLine("cPoint3 is null");
        }
    }
}
