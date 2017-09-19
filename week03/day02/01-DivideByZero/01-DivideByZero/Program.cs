using System;

namespace DivideByZero
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // create a function that takes a number
            // divides ten with it,
            // and prints the result.
            // it should print "fail" if the parameter is 0

            Console.WriteLine("Give me a number, so I can divide ten with it!");
            int input = int.Parse(Console.ReadLine());
            int number = 10;
			DivideByZero(number, input);
         

        }
        public static int DivideByZero(int number, int input)
        {
            int result = 0;
			try
			{
				result = number / input;
				Console.WriteLine(result);
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine("Cant divide by zero!");
			}
            return result;
        }
       
    }
}
