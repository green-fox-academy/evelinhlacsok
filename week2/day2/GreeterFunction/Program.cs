using System;
using System.Collections.Generic;

namespace GreeterFunction
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // - Create a string variable named `al` and assign the value `Greenfox` to it
            // - Create a function called `greet` that greets it's input parameter
            //     - Greeting is printing e.g. `Greetings dear, Greenfox`
            // - Greet `al`

            string al = "Greenfox";
            greet(al);
            Console.WriteLine(al);

        }

        public static void greet(string al)
        {
            Console.WriteLine("Greetings dear, " + al);
            Console.ReadLine();
        }
    }
}