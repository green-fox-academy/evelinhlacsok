using System;
using System.Collections.Generic;

namespace exam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create a function that takes a list of strings and a letter and returns a string " +
            //"where the strings are joined with the given letter like: " +
            //"["ab", "cde", "fg"] and " " becomes "ab cde fg""

            var list = new List<string> { "kuty", "rók", "halacsk" };
            char letter = 'a';
            Console.WriteLine(Append(list, letter));
        }

        public static string Append(List<string> list, char letter)
        {
            return String.Join(letter, list);
        }
    }
}
