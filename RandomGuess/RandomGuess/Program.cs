using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGuess
{
    class Program// by Austin Burks
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a number from 1 to 100");
            int guess = Convert.ToInt32(Console.ReadLine());

            Random rdmGen = new Random();
            int randomNumber = rdmGen.Next(1, 100);

            while (guess != randomNumber)
            {
                if (guess > randomNumber)
                {
                    Console.WriteLine("Your guess is too high. Guess again");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                else
                {
                    Console.WriteLine("Your guess is too low. Guess again");
                    guess = Convert.ToInt32(Console.ReadLine());
                }
                
            }

            Console.WriteLine($"You guessed right! Your number was {randomNumber}");
            Console.ReadKey();
        }
    }
}
