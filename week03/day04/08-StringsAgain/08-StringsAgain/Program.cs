using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_StringsAgain
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively a new string where all the 'x' chars have been removed.
            Console.WriteLine(XRemover("xplantsx arex xfriendsx"));
            Console.ReadLine();

        }

        private static string XRemover(string input)
        {
           // string result;
            int inputlength = input.Length;
            if (inputlength == 0)
                return "";
            else
                if (input[0] == 'x')
            {
                return XRemover(input.Substring(1));
            }
            else
            {
               return input[0] + XRemover(input.Substring(1));
            }
        }
    }
}
