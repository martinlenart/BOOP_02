using System;

namespace BOOP_02_14
{
    class Program
    {
        static void Main(string[] args)
        {
            int iScope1 = 500;
            {
                int iScope2 = ++iScope1;
                {
                    int iScope3 = ++iScope2;
                    {
                        //int iScope3 = 0;        // Compiler error - iScope3 already defined in outer scope
                        Console.WriteLine(iScope1 + iScope2 + iScope3); // 1505
                    }

                    Console.WriteLine(iScope1 + iScope2 + iScope3); // 1505
                }

                //Console.WriteLine(iScope1 + iScope2 + iScope3); // Compiler error - iScope3 out of scope
                Console.WriteLine(iScope1 + iScope2); // 1003
            }
            //Console.WriteLine(iScope1 + iScope2); // // Compiler error - iScope2 out of scope
            Console.WriteLine(iScope1); // 501
        }
    }
}
