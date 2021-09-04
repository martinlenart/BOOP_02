using System;

namespace BOOP_02_09
{
    class Program
    {
        static void Main(string[] args)
        {
            // Format using string interpolations
            decimal price = 582.5555M;

            //Format as Currency
            Console.WriteLine($"Product A costs: {price:C}");
            Console.WriteLine($"Product B costs: {price*5:C}");

            // Format the price right adjusted in a column 20 characters wide and 4 decimals
            Console.WriteLine();
            Console.WriteLine($"Product A costs: {price,20:C4}");
            Console.WriteLine($"Product B costs: {price * 5,20:C4}");

            // Format a byte and int in hex
            byte data = 0xAF;
            Console.WriteLine();
            Console.WriteLine($@"""data"" in decimal: {data}");
            Console.WriteLine($"{data} in hexdecimal 2digits: 0x{data:X2}");
            Console.WriteLine($"{data} in hexdecimal 4digits: 0x{data:X4}");


            string book1 = "Robinson Cruisoe";
            string author1 = "Daniel Defoe";
            decimal price1 = 125.50M;
            string book2 = "Count of Monte Christo";
            string author2 = "Alexandre Dumas";
            decimal price2 = 119.75M;

            // Format in a table
            Console.WriteLine();
            Console.WriteLine($"{"Article",-7} {"Title",-30} {"Author",-30} {"Price",20}");
            Console.WriteLine($"{"1:",-7} {book1,-30} {author1,-30} {price1,20:C2}");
            Console.WriteLine($"{"2:",-7} {book2,-30} {author2,-30} {price2,20:C2}");
        }
    }
}
