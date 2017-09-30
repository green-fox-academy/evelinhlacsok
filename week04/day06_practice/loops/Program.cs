using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Security;
using System.Security.Cryptography.X509Certificates;

namespace loops
{
    internal class Program
    {
        public static void Main(string[] args)
        {

            // Write a program that reads a number from the standard input, then draws a
            // pyramid like this:
            //
            //
            //    *
            //   ***
            //  *****
            // *******
            //
            // The pyramid should have as many lines as the number was

            Console.WriteLine("enter a number");
            int number = int.Parse(Console.ReadLine());
            string sign = "*";
            string space = " ";
            Drawpyramid(number, sign, space);
            Console.WriteLine();
        }

        public static void Drawpyramid(int number, string sign, string space)
        {
            for (int i = 1; i <= number; i++)
            {
               
                for (int j = 1; j < number-i+1; j++)
                {
                    Console.Write(space);
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(sign);
                    Console.Write(space);
                }
                Console.WriteLine();
            }
        }

    }
}
