using System;
using System.Collections.Generic;
using System.Linq;

namespace anagramma
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("word from which i create the palindrom from");
            string word = Console.ReadLine();
            Console.WriteLine(PalindromBuilder(word));
        }

        public static string PalindromBuilder (string word)
        {
            char[] chars = word.ToCharArray();
            Array.Reverse(chars);
            string palindrome = new string(chars);
            return word += palindrome;
        }

    }
}