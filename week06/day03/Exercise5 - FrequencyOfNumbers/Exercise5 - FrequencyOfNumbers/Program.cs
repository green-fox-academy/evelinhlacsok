using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise5___FrequencyOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find the frequency of numbers in the following array:

            int[] n = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };

            var frequencyWithQuery = from freq in n
                                                  orderby freq ascending
                                                  group freq by freq into UniqNum
                                                  select new
                                                  {
                                                      UniqNum.Key,
                                                      Count = (from freq in UniqNum select freq).Count()
                                                  };

            foreach (var number in frequencyWithQuery)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            var frenquencyWithLambda = n.OrderBy(y => y).GroupBy(y => y).Select(y => y.Count());

            foreach (var number in frenquencyWithLambda)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
