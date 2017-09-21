using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_Bunny2
{
    class Program
    {
        static void Main(string[] args)
        {
            // We have bunnies standing in a line, numbered 1, 2, ... The odd bunnies
            // (1, 3, ..) have the normal 2 ears. The even bunnies (2, 4, ..) we'll say
            // have 3 ears, because they each have a raised foot. Recursively return the
            // number of "ears" in the bunny line 1, 2, ... n (without loops or multiplication).
            Console.WriteLine(BunnyEars(5));
            Console.ReadLine();

        }
        private static int BunnyEars (int bunnies)
        {
            if (bunnies == 0)
            {
                return 0;
            }
            if (bunnies % 2 == 0)
            {
                return 3 + BunnyEars(bunnies - 1);
            }
            return 2 + BunnyEars(bunnies - 1);    
        }
    }
}
