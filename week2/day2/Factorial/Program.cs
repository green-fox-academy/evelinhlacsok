using System;
using System.Collections.Generic;

namespace Factorial
{
    internal class Program
    {
        public static void Main(string[] args)
        
            // - Create a function called `factorio`
            //   that returns it's input's factorial

        {
            int number = 5;
            
            Console.WriteLine(factorial(number));
        }

        public static int factorial(int number)
        {
            for (int i = number; i > 1; i--)
            {
                number *= (i - 1);
            }
            return number;
        }
    }
}