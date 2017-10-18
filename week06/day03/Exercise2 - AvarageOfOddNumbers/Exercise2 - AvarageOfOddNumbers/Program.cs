using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise2___AvarageOfOddNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
           // Write a LINQ Expression to get the average value of the odd numbers from the following array:

            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            IEnumerable<int> oddNumbers = from odds in n
                                          where odds % 2 == 1
                                          select odds;

            Console.WriteLine(oddNumbers.Average());
            Console.ReadLine();
        }
    }
}
