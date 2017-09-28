using System;
using System.Collections.Generic;

namespace Lists04
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        var list = new List<object>();
            list.Add("Cupcake");
            list.Add(2);
            list.Add("Brownie");
            list.Add(false);

            for (int i = 0; i < list.Count; i++)
            {
                if (i==1)
                {
                    list[i] = "Croissant";
                }

                if (i == 3)
                {
                    list[3] = "Ice cream";
                }
            }

            foreach (var added in list)
            {
                Console.WriteLine(added);
            }

            // Accidentally we added "2" and "false" to the list. 
            // Your task is to change from "2" to "Croissant" and change from "false" to "Ice cream"
            // No, don't just remove the lines

                   
        }
    }
}