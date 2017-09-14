using System;
using System.Collections.Generic;

namespace Lists07
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<string> { "What", "I", "do", "create,", "I", "cannot", "not", "understand." };
            
            
                string swap = list[2];
                list[2] = list[5];
                list[5] = swap;

            foreach (var quote in list)
            {
                Console.Write(quote + " ");
            }
            
            
            
            // Accidentally I messed up this quote from Richard Feynman.
            // Two words are out of place
            // Your task is to fix it by swapping the right words with code

            // Also, print the sentence to the output with spaces in between.
            
            // What I cannot create, I do not understand
            // swap cannot and do
        }
    }
}