using System;
using System.Collections.Generic;

namespace day01_28_DrawTriangle
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // triangle like this:
            //
            // *
            // **
            // ***
            // ****
            //
            // The triangle should have as many lines as the number was
            
            Console.WriteLine("Enter a number");
            int number = int.Parse(Console.ReadLine());
            string sign = "";

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine(sign = "*" + sign);
            }

        }
    }
}