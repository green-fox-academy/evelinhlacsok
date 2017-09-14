using System;
using System.Collections.Generic;

namespace day01_12_cuboid
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Write a program that stores 3 sides of a cuboid as variables (doubles)
            // The program should write the surface area and volume of the cuboid like:
            //
            // Surface Area: 600
            // Volume: 1000

            double slide1 = 5;
            double slide2 = 5;
            double slide3 = 5;
            
            Console.WriteLine("Surface Area: " + 6 * slide1 * slide2 + " m2");
            Console.WriteLine("Volume: " + slide1 * slide2 * slide3 + " m3");

        }
    }
}