using System;
using System.Collections.Generic;

namespace week02_day02_ReverseList
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // - Create an array variable named `ai`
            //   with the following content: `[3, 4, 5, 6, 7]`
            // - Print the sum of the elements in `ai`
            
            int[] ai = new int[]{3, 4, 5, 6, 7};
            Array.Reverse(ai);

            foreach (var element in ai)
            {
                Console.Write(element + ", ");
            }
        }
    }
}