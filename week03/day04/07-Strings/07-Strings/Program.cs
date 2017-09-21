using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given a string, compute recursively (no loops) a new string where all the
            // lowercase 'x' chars have been changed to 'y' chars.
            Console.WriteLine(XChanger("xaaaxaaaxaaaxaaa"));
            Console.ReadLine();
        }
  
        private static string XChanger(string input)
        {
            string result;
            int inputlength = input.Length;
           // char myChar = 'x';
            if (inputlength == 0)
            {
                return "";
            }
            else
            {
                if (input[0] == 'x')
                {
                    result = "y";
                  //  string output = result + XChanger(input.Substring(1));
                    return result + XChanger(input.Substring(1));
                }
                else
                {
                   // string output = input + XChanger(input.Substring(1));
                    return input[0] + XChanger(input.Substring(1));
                }
                    
            }


        }
    }
}
