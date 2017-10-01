using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace strings2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Create a simple calculator application which reads the parameters from the prompt
            // and prints the result to the prompt.
            // It should support the following operations:
            // +, -, *, /, % and it should support two operands.
            // The format of the expressions must be: {operation} {operand} {operand}.
            // Examples: "+ 3 3" (the result will be 6) or "* 4 4" (the result will be 16)

            // You can use the Scanner class
            // It should work like this:

            // Start the program
            // It prints: "Please type in the expression:"
            // Waits for the user input
            // Print the result to the prompt
            // Exit

            Console.WriteLine("add first operand");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("operation (suppoerted are: +, -, /, *, %");
            string operation = (Console.ReadLine());
            Console.WriteLine("second operand");
            int number2 = int.Parse(Console.ReadLine());
            Calculator(number1, operation, number2);

        }

        public static void Calculator (int number1, string operation, int number2)
        {
            if (operation == "+")
            {
                Console.WriteLine(number1 += number2);
            }
            else if (operation == "-")
            {
                Console.WriteLine(number1 -= number2);
            }
            else if (operation == "/")
            {
                Console.WriteLine(number1 /= number2);
            }
            else if (operation == "*")
            {
                Console.WriteLine(number1 *= number2);
            }
            else if (operation == "%")
            {
                Console.WriteLine(number1 %= number2);
            }
            else
            {
                Console.WriteLine("that operation is not supported");
            }
            return;
        }
    }
}