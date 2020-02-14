using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation_5._2
{
    class Program
    {
        // by Austin Burks
        const double InterestRate = .0325;
        static void Main(string[] args)
        {
            Console.WriteLine("what is your starting balance?");
            double balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("How many months will it mature");
            int months = Convert.ToInt32(Console.ReadLine());
            int index = 0;
            while (index < months)
            {
                balance = balance + (balance * InterestRate);
                Console.WriteLine(index++.ToString());
                Console.WriteLine(balance.ToString("C2"));
            }
            
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
