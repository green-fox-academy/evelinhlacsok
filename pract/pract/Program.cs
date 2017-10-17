using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pract
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "robinson";
            //string greeting = name == "robinson" ? "good morning robinson" : "hi";
            //Console.WriteLine(greeting);
            //Console.ReadLine();

            List<int> numbers = new List<int>() { 4, 6, 2, 1 };
            numbers.Add(8);
            numbers.Sort();
            string sortedNumbers = String.Join(", ", numbers);
            Console.WriteLine(sortedNumbers);
            numbers.Add(3);
            numbers.Sort();
            string sorted2 = String.Join(", ", numbers);
            Console.WriteLine(sorted2);
            Console.ReadLine();
        }
    }
}
