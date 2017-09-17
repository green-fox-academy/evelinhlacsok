using System;
using System.Collections.Generic;

namespace day01_29_DrawPyramid
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

            Console.WriteLine("how big the pyramid should be? give me a number!");
            int number = int.Parse(Console.ReadLine());
            string sign = " ";
            string space = " ";

            for (int i = 1; i <= number; i++)
            {
                for (int j = 1; j < number-i+1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Console.Write(i);
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
               
            {
                /* for (int j = 0; j < number - i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k < number +1 ; k++)
                {
                    Console.Write("*");
                }
                for (int l = 0; l < number + i; l++)
                {
                    Console.Write(" ");
                }
                
                Console.WriteLine(); */
            }
        }
    }
}