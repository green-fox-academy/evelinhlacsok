using System;
using System.Collections.Generic;
using System.IO;

namespace IO
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("../../abc.txt");
            string text = sr.ReadLine();
            while (text != null )
            {
                Console.WriteLine(text);
                text = sr.ReadLine();
            }
            
            StreamWriter wr = new StreamWriter("../../abc.txt");
            string poem = wr.w
        }
    }
}