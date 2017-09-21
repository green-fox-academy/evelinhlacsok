using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Counter
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and counts down from n.
            CounterWithRecursion(8);
            Console.ReadLine();
            
        }
        public static void CounterWithRecursion (int n)
        {
            if (n < 0)
                return;
            Console.WriteLine(n);
            CounterWithRecursion(n - 1);

        }
    }
}
