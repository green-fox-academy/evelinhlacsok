using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise7___StartsAndEndsWGivenLetters
{
    class Program
    {
        static void Main(string[] args)
        {
           // Write a LINQ Expression to find the strings which starts with A and ends with I in the following array:

            string[] cities = { "ROME", "LONDON", "NAIROBI", "CALIFORNIA", "ZURICH", "NEW DELHI", "AMSTERDAM", "ABU DHABI", "PARIS" };

            var startAndEndWithQuery = from city in cities
                                       where city.StartsWith("A") && city.EndsWith("I")
                                       select city;

            foreach (var city in startAndEndWithQuery)
            {
                Console.WriteLine(city);
            }

            Console.WriteLine();

            var startAndEndWithLambda = cities.Where(x => x.StartsWith("A") && x.EndsWith("I")).ToList();

            foreach (string city in startAndEndWithLambda)
            {
                Console.WriteLine(city);
            }
            Console.ReadLine();
        }
    }
}
