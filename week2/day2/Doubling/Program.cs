using System;
using System.Collections.Generic;

namespace Doubling
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // - Create an integer variable named `ak` and assign the value `123` to it
            // - Create a function called `doubling` that doubles it's input parameter
            // - Print the result of `doubling(ak)`

            int ak = 123;
            Doubling(ak);
            Console.WriteLine(ak);
            
        }

        public static void Doubling(int ak)
        {
            Console.WriteLine(ak*2);
            Console.ReadLine();
        }
    }
}