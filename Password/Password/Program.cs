using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Password
{
    class Program
    {
        static void Main(string[] args)
        {
            string string1 = "blah";
            string string2 = "dub";
            string password = "Sooners1957";
            Console.WriteLine("Enter the password");
            string userInput = Console.ReadLine();
            int index = 0;
            while (userInput != password && index < 3)
            {
                Console.WriteLine("Incorrect Password. Please try again.");
                userInput = Console.ReadLine();
                index++;
            }

            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine("Press any key to exit ... ");
            Console.ReadKey();
        }
    }
}
