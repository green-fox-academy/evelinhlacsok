using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace Strings05
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string str = ".eslaf eb t'ndluow ecnetnes siht ,dehctiws erew eslaf dna eurt fo sgninaem eht fI";
            Console.WriteLine(Reverse(str));

            Console.ReadLine();

        }

        public static string Reverse(string str)
        {
            char[] chars = str.ToCharArray();
            int j = chars.Length - 1;
            for (int i = 0; i < chars.Length/2; i++)
            {
                char temp = chars[i];
                chars[i] = chars[j];
                chars[j] = temp;
                j--;
            }
            return new string(chars);


        }

    }
}