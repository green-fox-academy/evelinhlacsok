﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            // The fibonacci sequence is a famous bit of mathematics, and it happens to
            // have a recursive definition. The first two values in the sequence are
            // 0 and 1 (essentially 2 base cases). Each subsequent value is the sum of the
            // previous two values, so the whole sequence is: 0, 1, 1, 2, 3, 5, 8, 13, 21
            // and so on. Define a recursive fibonacci(n) method that returns the nth
            // fibonacci number, with n=0 representing the start of the sequence.

            Console.WriteLine(Fibonacci(0, 1, 1));
            Console.ReadLine();
        }
        private static int Fibonacci (int n1, int n2, int n3)
        {

        }
    }
}
