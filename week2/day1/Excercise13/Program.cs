using System;
using System.Collections.Generic;

namespace Excercise13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int currentHours = 16;
            int currentMinutes = 17;
            int currentSeconds = 42;

            int totalHours = 23 - currentHours;
            int totalMinutes = 59 - currentMinutes;
            int totalSeconds = 59 - currentSeconds;

            Console.WriteLine(totalHours * 3600 + totalMinutes * 60 + totalSeconds);


        }
    }
}