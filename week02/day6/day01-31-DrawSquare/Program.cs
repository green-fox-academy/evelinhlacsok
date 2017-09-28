using System;
using System.Collections.Generic;

namespace day01_31_DrawSquare
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
            // %   %
            // %   %
            // %   %
            // %   %
            // %%%%%
            //
            // The square should have as many lines as the number was
            
            Console.WriteLine("How many lines the square should have?");
            int number = int.Parse(Console.ReadLine());

            for (int i = 0; i < number; i++) // fist line
            {
                Console.Write("%");
            }
            Console.WriteLine();
            
            for (int i = 0; i < number; i++)
            {
                Console.Write("%");
                
                for (int j = 0; j < number-2; j++)
                {
                    Console.Write(" ");
                }
                Console.Write("%");
                Console.WriteLine();
            }
            for (int i = 0; i < number; i++) // last line
            {
                Console.Write("%");
            }
        }
    }
}