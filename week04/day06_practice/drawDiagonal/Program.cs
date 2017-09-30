using System;
using System.Collections.Generic;

namespace draw
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Write a program that reads a number from the standard input, then draws a
            // square like this:
            //
            //
            // %%%%%
            // %%  %
            // % % %
            // %  %%
            // %%%%%
            //
            // The square should have as many lines as the number was

            Console.WriteLine("lines of the square");
            int number = int.Parse(Console.ReadLine());

            string space = " ";
            string sign = "%";

            for (int i = 0; i <= number; i++) // teteje
            {
                Console.Write(sign);
            }
            Console.WriteLine();
            
            for (int i = 0; i < number; i++) // kozepe
            {
                Console.Write(sign);
                for (int j = 0; j < number-1; j++)
                {
                    if (i == j)
                    {
                        Console.Write(sign);
                    }
                    else
                    {
                        Console.Write(space);
                    }
               
                }
                for (int j = 0; j < 1; j++)
                {
                    Console.Write(sign);
                }
                Console.WriteLine();
            }
            
            for (int i = 0; i <= number; i++) // alja
            {
                Console.Write(sign);
            }
        }
    }
}