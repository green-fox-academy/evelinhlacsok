using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise8___UppercaseCharacters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the uppercase characters in a string!

            string input = "Most Is A Succulents Lesz";

            var uppercaseWithQuery = (from uppercase in input
                                      where char.IsUpper(uppercase)
                                      select uppercase).ToList();

            foreach (var letter in uppercaseWithQuery)
            {
                Console.WriteLine(letter);
            }

            Console.WriteLine();

            var uppercaseWithLambda = input.Where(x => char.IsUpper(x)).ToList();
            foreach (var letter in uppercaseWithLambda)
            {
                Console.WriteLine(letter);
            }

            Console.ReadLine();


            //var uppercaseWithLambda = input.Select(x => (Exists(x)) ? x.ToUpper() : x);

        }
    }
}
