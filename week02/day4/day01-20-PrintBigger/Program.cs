using System;
using System.Collections.Generic;

namespace day01_20_PrintBigger
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Write a program that asks for two numbers and prints the bigger one
            
            Console.WriteLine("Enter a number");
            int number1 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("and a second number");
            int number2 = int.Parse(Console.ReadLine());

            if (number1 > number2)
            {
                Console.WriteLine("the bigger number was: " + number1);
            }
            else
            {
                Console.WriteLine("the bigger number was: " + number2);
            }
            
           
            
        }
    }
}