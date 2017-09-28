using System;
using System.Collections.Generic;

namespace Lists03
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        var far = new List<string> {"kuty", "macsk", "kacs", "rók", "halacsk"};
                    // Add "a" to every string in the far list.
            foreach (var fullname in far)
            {
                Console.WriteLine(fullname + "a");
            }
            
                    
        }
    }
}