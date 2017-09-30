using System;
using System.Collections.Generic;

namespace week02_day02_SwapElements
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // - Create an array variable named `abc`
            //   with the following content: `["first", "second", "third"]`
            // - Swap the first and the third element of `abc`
            
            string[] abc = new string[]{"first", "second", "third"};

            string temp = abc[0];
            abc[0] = abc[2];
            abc[2] = temp;

            foreach (var element in abc)
            {
                Console.Write(element + ", ");
            }
        }
    }
}