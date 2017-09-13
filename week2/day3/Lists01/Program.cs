using System;
using System.Collections.Generic;

namespace Lists01
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var planetList = new List<string> { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Uranus",
                "Neptune" };
            planetList = planetList.Insert("Saturn")
        

            // Saturn is missing from the planetList
            // Insert it into the correct position

            Console.WriteLine(planetList);
        }
    }
}