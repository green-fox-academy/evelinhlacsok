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

            Console.ReadLine();

        }

        public static string Palindrome(string userinput)
        {
             char[] chars = userinput.ToCharArray();
            int j = chars.Length - 1;
            for (int i = 0; i < chars.Length/2; i++)
            {
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
                j--;
            }
            return new string(chars);
        }
    }
}