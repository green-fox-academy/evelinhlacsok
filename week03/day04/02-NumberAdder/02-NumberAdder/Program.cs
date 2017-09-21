using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_NumberAdder
{
    class Program
    {
        static void Main(string[] args)
        {
            // Write a recursive function that takes one parameter: n and adds numbers from 1 to n.
            Console.WriteLine(NumberAdder(9));
            Console.ReadLine();
        }
        private static int NumberAdder (int n)
        {
            if (n<0)
                return 0;
            return n + NumberAdder(n - 1);
        }
      //  private static int  NumberAdder (int n)
       // {
        //    if (n == 1)
       //         return 1;
        //    return n + NumberAdder(n - 1);
       // }
    }
}
