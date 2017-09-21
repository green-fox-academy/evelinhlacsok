using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_StringsAgainAndAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the
            // adjacent chars are now separated by a "*".
            Console.WriteLine(StarSeparator("plants are friends honey"));
            Console.ReadLine();
        }

        private static string StarSeparator(string input)
        {
            string result;
            int inputlength = input.Length;
            if (inputlength == 0)
            {
                return "";
            }
            else
            {
                if (input[0] == ' ')
                {
                    result = "*";
                    return result + StarSeparator(input.Substring(1));
                }
                else
                {
                    return input[0] + StarSeparator(input.Substring(1));
                }
            }
    
        }
    }
}
