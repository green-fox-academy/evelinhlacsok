using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Globalization;
using System.Security;

namespace loops
{
    internal class Program
    {
        public static void Main(string[] args)
        {

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
                for (int i = firstnumber; i <= secondnumber; i++)
                {
                    Console.WriteLine(firstnumber++);
                }

            }
        }
    }
}