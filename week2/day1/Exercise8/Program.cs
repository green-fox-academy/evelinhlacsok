using System;
using System.Collections.Generic;

namespace Excercise8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int a = 123;
            int b = 526;
            int c = a + b;

            a = c - a;
            b = c - b;
        }
    }
}