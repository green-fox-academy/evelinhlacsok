using System;
using System.Collections.Generic;
using System.Linq;

namespace Anagram
{
    internal class Program
    {
        public static void Main(string[] args)
        {
         //Create a function named is anagram following your current language's style guide. 
         //It should take two strings and return a boolean value depending on whether its an anagram or not.
            
            Console.WriteLine("The first word is: ");
            string firstword = Console.ReadLine();
            
            Console.WriteLine("The second word is: ");
            string secondword = Console.ReadLine();
            
            Console.WriteLine(Anagram(firstword, secondword));
        }

        public static string Anagram(string word1, string word2)
        {
            if (word1.Length != word2.Length)
            {
                
            }
        }
    }
}