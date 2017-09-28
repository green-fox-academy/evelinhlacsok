using System;
using System.Collections.Generic;

namespace Excercise16
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            // Write a program that asks for two integers
            // The first represents the number of chickens the farmer has
            // The seconf represents the number of pigs the farmer has
            // It should print how many legs all the animals have
            
            Console.WriteLine("Enter the number of chickens");
            int chickens = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of pigs");
            int pigs = int.Parse(Console.ReadLine());
            int totallegs = chickens * 2 + pigs * 4;
            
            Console.WriteLine("That is " + totallegs + " legs all together");
           
        }
    }
}