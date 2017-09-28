using System;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;

namespace day01_26_CountFromTo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create a program that asks for two numbers
            // If the second number is not bigger than the first one it should print:
            // "The second number should be bigger"
            //
            // If it is bigger it should count from the first number to the second by one
            //
            // example:
            //
            // first number: 3, second number: 6, should print:
            //
            // 3
            // 4
            // 5
            
            Console.WriteLine("Give me the first number");
            int firstnumber = int.Parse(Console.ReadLine());
            
            Console.WriteLine("and the second number");
            int secondnumber = int.Parse(Console.ReadLine());

            if (secondnumber < firstnumber)                                                                   
            {
                Console.WriteLine("The second number should be bigger");
            }
            else
            {
                for (int i = 0; i < secondnumber; i++)
                {
                    Console.WriteLine(secondnumber - (i+1));
                }
            }
        }
    }
}