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
            firstword = firstword.ToLower();
            
            Console.WriteLine("The second word is: ");
            string secondword = Console.ReadLine();
            secondword = secondword.ToLower();
            
            Console.WriteLine("Your senctence is an anagrama: " + Anagram(firstword, secondword));

            Console.ReadLine();
        }

        public static bool Anagram(string word1, string word2)
        {
            
            char[] array1 = word1.ToCharArray();
            char[] array2 = word2.ToCharArray();
            
            Array.Sort(array1);
            Array.Sort(array2);
            
            string newstring1 = new string(array1);
            string newstring2 = new string(array2);
            
            if (newstring1 == newstring2)
            {
                return true;
            }
            return false;

           
        }
    }
}