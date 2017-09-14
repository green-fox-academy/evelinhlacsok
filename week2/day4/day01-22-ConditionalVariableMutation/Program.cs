using System;
using System.Collections.Generic;

namespace day01_22_ConditionalVariableMutation
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            double a = 24;
            int out1 = 0;

            if (a % 2 == 0)
                // if w is even increment out by one
            {
                Console.WriteLine(out1 + 1);
            }
            

            int b = 13;
            string out2 = "";
            // if b is between 10 and 20 set out2 to "Sweet!"
            // if less than 10 set out2 to "More!",
            // if more than 20 set out2 to "Less!"

            if (10 < b && b < 20)
            {
                out2 = "Sweet!";
            }
            else if (b < 10)
            {
                out2 = "More!";
            }
            else 
            {
                out2 = "Less!";
            }

            Console.WriteLine(out2);

            int c = 123;
            int credits = 100;
            bool isBonus = false;
            // if credits are at least 50,
            // and isBonus is false decrement c by 2
            // if credits are smaller than 50,
            // and isBonus is false decrement c by 1
            // if isBonus is true c should remain the same

            if ((credits >= 50) && (isBonus == false))
            {
                c -= 2;
            }
            else if ((credits < 50) && (isBonus == false))
            {
                c -= 1;
            }
            else if (isBonus == true)
            {
                c = c;
            }
          
            Console.WriteLine(c);

            int d = 8;
            int time = 120;
            string out3 = "";
            // if d is dividable by 4
            // and time is not more than 200
            // set out3 to "check"
            // if time is more than 200
            // set out3 to "Time out"
            // otherwise set out3 to "Run Forest Run!"

            if ((d % 4 == 0) && (time < 200))
            {
                out3 = "check";
            }
            else if (time > 200)
            {
                out3 = "Time out";
            }
            else
            {
                out3 = "Run Forest Run!";
            }

            Console.WriteLine(out3);
        }
    }
}