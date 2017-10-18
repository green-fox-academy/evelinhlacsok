using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise6___FrequencyOfCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of characters in a given string!

            //string[] characters = new string[] { "s", "u", "c", "c", "u", "l", "e", "n", "t", "s" };
            string characters ="succulents";

            var frequencyWithQuery = from freq in characters
                                     orderby freq ascending
                                     group freq by freq into UniqChar
                                     select new
                                     {
                                         UniqChar.Key,
                                         Count = (from freq in UniqChar select freq).Count()
                                     };

            foreach (var character in frequencyWithQuery)
            {
                Console.WriteLine(character);
            }
            Console.ReadLine();
        }
    }
}
