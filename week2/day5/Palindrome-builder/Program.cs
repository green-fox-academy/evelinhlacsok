using System;
using System.Collections.Generic;
using System.Linq;

namespace Palindrome_builder
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        //Create a function named create palindrome following your current language's style guide. 
        //It should take a string, create a palindrome from it and then return it.
            
            Console.WriteLine("I need a word to create a palindrome from: ");
            string input = Console.ReadLine();
            
            Console.WriteLine(input + Palindrome(input));

        }

        public static string Palindrome(string userinput)
        {
            return userinput;
        }
    }
}