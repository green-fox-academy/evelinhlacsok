using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Reflection;
using System.Runtime.InteropServices;

namespace week02_day02_Printer
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // - Create a function called `printer`
            //   which prints the input String parameters
            // - It can have any number of parameters

            // Examples
            // printer("first")
            // printer("first", "second")
            // printer("first", "second", "third", "fourh")
            // ...

            string[] parameter = {"pal", "kata", "peter", "joreggelt"};
            Printer(parameter);
        }

        public static void Printer(string[] parameter)
        {
            for (int i = 0; i < parameter.Length; i++)
            {
                Console.WriteLine(parameter[i]);
            }
        }
    }
}