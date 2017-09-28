using System;
using System.Collections.Generic;

namespace day01_35_DrawChessTable
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        // Crate a program that draws a chess table like this
                    //
                    // % % % %
                    //  % % % %
                    // % % % %
                    //  % % % %
                    // % % % %
                    //  % % % %
                    // % % % %
                    //  % % % %
                    //
            string sign = "%";
            string space = " ";

          //  Console.WriteLine("#" + " " + "#" + " ");
          //Console.WriteLine(" " + "#" + " " + "#");

           for (int i = 1; i <= 8; i++)
           {
                if (i % 2 == 0)
                {
                    Console.Write(space);
                } 
                for (int j = 0; j <= 8; j++)
                {
                    if (j % 2 == 0)
                    {
                        Console.Write(sign);
                    }
                    else
                    {
                        Console.Write(space);
                    }
                }
                Console.WriteLine();
            }
            
        }
    }
}