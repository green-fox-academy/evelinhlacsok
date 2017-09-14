using System;
using System.Collections.Generic;

namespace day01_32_DrawDiagonal
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
            
            Console.WriteLine("How big the square should be? Give me a number!");
            int squaresize = int.Parse(Console.ReadLine());

            for (int i = 0; i < squaresize; i++) //1st row
            {
                Console.Write("%");
            }
            Console.WriteLine();

            for (int i = 0; i < squaresize - 2; i++)
            {
                Console.Write("%");  //1s column
            
                for (int j = 0; j < squaresize - 2; j++)
                {
                    if (j == i)
                    {
                        Console.Write("%");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }    
            Console.Write("%");  //last column
            Console.WriteLine();
            }   
            
            for (int i = 0; i < squaresize; i++)   //last row
            {
                Console.Write("%");
            }
        }
        
    }
}