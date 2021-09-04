using System;

namespace BOOP_03_03
{
    class Program
    {
        public enum MonthOfYear { January, February, March, 
                                  April, May, June,
                                  July, August, September,
                                  October, November, December}
        static void Main(string[] args)
        {
            MonthOfYear month = MonthOfYear.January;
            Console.WriteLine(month);       // January
            Console.WriteLine((int)month);  // 0

            if (month == MonthOfYear.January) Console.WriteLine("Happy New Year");
        }
    }
}
