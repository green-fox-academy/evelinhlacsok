using System;
using System.Collections.Generic;

namespace day01_33_GuessTheNumber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Write a program that stores a number, and the user has to figure it out.
            // The user can input guesses, after each guess the program would tell one
            // of the following:
            //
            // The stored number is higher
            // The stried number is lower
            // You found the number: 8


            int number = 7;
            
            Console.WriteLine("guess the number!");
            int guess = 1;

            while (guess != number)
            {
                guess = int.Parse(Console.ReadLine());
                if (number < guess)
                {
                    Console.WriteLine("The stored number is lower");
                }
                else if (number > guess)
                {
                    Console.WriteLine("The stored number is higher");
                }
                Console.WriteLine("Try to guess again!");
            }
            
            if (guess == number)
            {
                Console.WriteLine("You found the number: 7");
            }

        }
    }
}