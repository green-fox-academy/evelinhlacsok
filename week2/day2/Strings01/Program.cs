using System;
using System.Collections.Generic;

namespace Strings01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string example = "In a dishwasher far far away";
            

            Console.WriteLine(example.Replace("dishwasher", "galaxy"));

            // I would like to replace "dishwasher" with "galaxy" in this example, but it has a problem.
            // Please fix it for me!
            // Expected ouput: In a galaxy far far away

            //Console.WriteLine(example);
        }
    }
}