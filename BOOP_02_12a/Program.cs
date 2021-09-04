﻿using System;
using System.Threading.Tasks;

namespace BOOP_02_12a
{
    class Program
    {
        public struct constVsStaticReadonly
        {
            public const double twoPI = 2 * System.Math.PI;
            public static readonly DateTime staticCreationTime = DateTime.Now;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(constVsStaticReadonly.twoPI); // 6.28... Will never change
            Console.WriteLine(constVsStaticReadonly.staticCreationTime); // time of static staticCreationTime init
            Task.Delay(5000);                                            // Delay 5 sec   
            Console.WriteLine(constVsStaticReadonly.staticCreationTime); // Same time as above
        }
    }
}
