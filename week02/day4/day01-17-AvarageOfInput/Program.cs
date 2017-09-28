using System;
using System.Collections.Generic;

namespace day01_17_AvarageOfInput
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Write a program that asks for 5 integers in a row,
            // then it should print the sum and the average of these numbers like:
            //
            // Sum: 22, Average: 4.4
         
            Console.WriteLine("Enter a number");
            int number1 = int.Parse(Console.ReadLine());
          
            Console.WriteLine("a second one");
            int number2 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("a third one");
            int number3 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("a fourth one");
            int number4 = int.Parse(Console.ReadLine());
            
            Console.WriteLine("and a last one");
            int number5 = int.Parse(Console.ReadLine());

            int sum = number1 + number2 + number3 + number4 + number5;
            int avarage = (number1 + number2 + number3 + number4 + number5) / 2;
            
            Console.WriteLine("Sum: " + sum + ", " + "Avarage: " + avarage);
            



        }
    }
}