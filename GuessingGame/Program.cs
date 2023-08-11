using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
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
            string response;

            while (playagain)
            {
                guess = 0;
                guesses = 0;
                number = random.Next(min, max +1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max);
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess :" + guess);

                    if (guess < number)
                    {
                        Console.WriteLine("the number is still up");
                    }
                    else if (guess > number)
                    {
                        Console.WriteLine(guess + "still low");
                    }
                    guess++;
                }
                Console.WriteLine("Number " + number);
                Console.WriteLine("You Win");
                Console.WriteLine("Guesses: " + guesses);

                Console.WriteLine("Would You like to play again (Press Y/N) :");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    playagain = true;
                }
                else
                {
                    playagain = false;
                }
            }
            Console.WriteLine("Thanks for playing! I Guess");
            Console.ReadKey();
        }
    }
}


