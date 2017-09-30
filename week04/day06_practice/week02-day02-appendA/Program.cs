using System;
using System.Collections.Generic;

namespace week02_day02_appendA
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            
            // - Create an array variable named `nimals`
            //   with the following content: `["kuty", "macsk", "cic"]`
            // - Add all elements an `"a"` at the end
            string[]nimals = new string[]{"kuty", "macsk", "cic"};
            appendA(nimals);
        }

        public static void appendA(string[] nimals)
        {
            for (int i = 0; i < nimals.Length; i++)
            {
                Console.Write(nimals[i] + "a" + ", ");
            }
        }
    }
}