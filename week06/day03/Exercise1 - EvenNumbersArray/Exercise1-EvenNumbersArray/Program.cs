using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise1_EvenNumbersArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to get the even numbers from the following array:

            int[] n = { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };

            foreach (var evens in nLambda(n))
            {
            Console.WriteLine(evens);
            }
            Console.ReadLine();
        }
        //private static IEnumerable<int> nQuery (int[] n)          //this works well as well, but line 17 needs to be updated
        //{
        //    IEnumerable<int> nQuery = from even in n
        //                              where even % 2 == 0
        //                              select even;
        //    return nQuery;
        //}

        private static IEnumerable<int> nLambda (int[] n)
        {
            IEnumerable<int> evens = n.Where(y => y % 2 == 0);
            return evens;
        }
    }
}
