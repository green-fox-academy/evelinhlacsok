using System;
using System.Collections.Generic;

namespace strings
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string word1 = "applepie";
            string word2 = "cheesecake*";
            string word3 = "choco brownie";
            string email = "hello@me.com";

            Console.WriteLine(word1.Replace("apple", "pear"));

            char[] charsToTrim = {'*'};
            Console.WriteLine(word2.Trim(charsToTrim));

            Console.WriteLine(word3.Substring(0, word3.IndexOf('b')));
            string name = word3.Substring(word3.IndexOf(' ')+1);
            Console.WriteLine(name);

            Console.WriteLine(email.Substring(0, email.IndexOf('@')));
            Console.WriteLine(email.Substring(email.IndexOf('@') + 1));
            Console.WriteLine(email.TrimStart());
            Console.WriteLine(email.ToUpper());

        }
    }
}