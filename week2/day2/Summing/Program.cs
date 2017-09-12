using System;
using System.Collections.Generic;

namespace Summing
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // - Write a function called `sum` that sum all the numbers
            //   until the given parameter
            
            int number = 5;
            
            Console.WriteLine(Sum(number));
        }

        public static int Sum(int Input)
        {
            for (int i = Input; i > 0; i--)
            {
                Input += i - 1;
               
            }
            return Input;
        }
    }
}