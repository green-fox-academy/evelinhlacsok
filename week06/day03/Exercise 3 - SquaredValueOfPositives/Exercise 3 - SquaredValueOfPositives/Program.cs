using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_3___SquaredValueOfPositives
{
    class Program
    {
        static void Main(string[] args)
        {
           // Write a LINQ Expression to get the squared value of the positive numbers from the following array:

            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            IEnumerable<int> squareWithQuery = from square in n
                                               where square > 0
                                               select square * square;

            foreach (var number in squareWithQuery)
            {
            Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
