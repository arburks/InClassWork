using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03._05._20_InClassWork
{
    class Program
    {
        const string Password = "Sooners";
        static void Main(string[] args)
        {
            bool firstPass = true;
            int count = 0;
            string password = string.Empty;

            do
            {
                if (firstPass)
                {
                    Console.WriteLine("Enter the password");
                    password = Console.ReadLine();
                    firstPass = false;
                }
                else if (count < 3)
                {
                    Console.WriteLine($"Incorrect. Try Again. {3 - count} attempts remaining >>");
                    password = Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("Too many failed attempts. Failure to open the first lock!");
                    Console.ReadKey();
                    return;
                    //return ends the programs
                    //break will break out of loop, so right after while
                    //continue will break out of else but continue loop while condition is still met
                }

                count++;

            } while (password != Password);
        }
    }
}
