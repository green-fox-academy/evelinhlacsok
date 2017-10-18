using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise9___CharArrayToString
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to convert a char array to a string!

            char[] input = { 'd', 'o', 'g', 'g', 'o' };

            var toStringWithLambda = String.Join(".", input.Select(x => x));
            Console.WriteLine(toStringWithLambda);
            Console.ReadLine();



        }
    }
}
