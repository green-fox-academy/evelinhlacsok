using System;
using System.Collections.Generic;
using System.Linq;

namespace practice
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create a function that takes a list as a parameter,
             //and returns a new list with every second element from the orignal list
            // example: [1, 2, 3, 4, 5] should produce [2, 4]
            
            List<int>numbers = new List<int>(){1, 2, 3, 4};
            EverySecond(numbers);
        }

        private static void EverySecond(List<int> numbers)
        {
            List<int>secondElement = new List<int>();
            for (int i = 0; i < numbers.Count; i++)
            {
                if (i % 2 == 1)
                {
                    secondElement.Add(numbers[i]);
                }
            }
            foreach (var seconds in secondElement)
            {
                Console.Write(seconds + ", ");
            }
        }
    }
}