using System;
using System.Collections.Generic;

namespace Excercise18
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Write a number!");
            int number = int.Parse(Console.ReadLine());
            if (number % 2 == 0)
            {
                Console.WriteLine("Your number is even");
            }
            else
            {
                Console.WriteLine("Your number is odd");
            }
            Console.ReadLine();
        }
    }
}