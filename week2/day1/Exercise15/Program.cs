using System;
using System.Collections.Generic;

namespace Excercise15
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of kilometers, that you would like to convert to miles");
            int km = int.Parse(Console.ReadLine());
          
            Console.WriteLine("That is " + km * 0.621371 + " miles");
           


        }
    }
}