using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessingGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playagain = true;
            int min = 1;
            int max = 100;
            int guess;
            int number;
            int guesses;

            while (playagain)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(number);
            }
            while( guess != number)
            {
                Console.WriteLine("Guess a number between " + min + " - " + max);
                guess = Convert.ToInt32(Console.ReadLine());
               
            }

        }
    }
}
