using System;
using System.Collections.Generic;
using System.Xml.Linq;

namespace day05_project_GuessMyNumber
{
    internal class Program
    {
        public static void Main(string[] args)
        {
        /* Write a program where the program chooses a number between 1 and 100. The player is then asked to enter a guess.
        If the player guesses wrong, then the program gives feedback and ask to enter an other guess until the guess is correct.
        
        Make the range customizable (ask for it before starting the guessing).
        You can add lives. (optional) */
            
           
            
            Console.WriteLine("Guess my number! It is in between 1 and 100");
            int guess = 0;
            
            Random random = new Random();
            int guessNumber = random.Next(0, 100); //for ints
            int lives = 5;

            while (guess != guessNumber && lives != 0)
            {
                guess = int.Parse(Console.ReadLine());
                if (guessNumber < guess)
                {
                    Console.WriteLine("Too high!");
                    lives--;
                    Console.WriteLine("You got " + lives + " lives left");   
                }
                else if (guessNumber > guess)
                {
                    Console.WriteLine("Too low!");
                    lives--;
                    Console.WriteLine("You got " + lives + " lives left");
                }
                Console.WriteLine("Try to guess again!");
                
            }
            if (guess == guessNumber)
            {
                Console.WriteLine("That is right, " + guessNumber + " was my number! (๑˃̵ᴗ˂̵)و");
            }
            else if (lives == 0)
            {
                Console.WriteLine("So sorry, you are out of lives (╯︵╰,)̣̣̣̣)");
            }
        }
    }
}