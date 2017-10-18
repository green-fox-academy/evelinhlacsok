using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4___SquaredMoreThan20
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a LINQ Expression to find which number squared value is more then 20 from the following array:

            int[] n = new[] { 3, 9, 2, 8, 6, 5 };

            IEnumerable<int> squaredMoreThan20WithQuery = from square in n
                                                          where square * square > 20
                                                          select square;

            foreach (var number in squaredMoreThan20WithQuery)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();

            IEnumerable<int> squaredMoreThan20WithLambda = n.Where(y => y * y > 20);
            foreach (var number in squaredMoreThan20WithLambda)
            {
                Console.WriteLine(number);
            }
            Console.ReadLine();
        }
    }
}
