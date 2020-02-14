using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._13._20_InClassWork
{
    class Program
    {
        static void Main(string[] args)
        {
            //TryParse

            //Console.WriteLine("Input a number between 1 & 10");
            ////strin input = Console.ReadLine();
            //bool isANumber = Int32.TryParse(Console.ReadLine(), out int inputAsANumber); //if TryParse runs, then bool is true
            //double.TryParse(Console.ReadLine(), out double inputAsADouble); //if letter enter output will be zero
            ////can also be in an if statement, if TryParse runs then if is true and will run
            //if (Int32.TryParse(Console.ReadLine(), out int inputAsANumberIf))
            //{

            //}
            //Console.ReadKey();

            //Do Loop vs While Loop

            int index = 0;
            int index2 = 0;
            //int index = 1;
            //int index 2 = 1;

            Console.WriteLine("Do while loop:");
            do
            {
                Console.WriteLine($"Index count is: {index} in the loop before increment", index++);
                Console.WriteLine($"Index count is: {index} in the loop after increment");
            }
            while (index < 1);
            Console.WriteLine($"Index count is: {index} outside the loop after the increment");

            Console.WriteLine("While loop:");
            Console.WriteLine($"Index count is: {index2} in the loop before increment");
            while (index2 < 1)
            {
                Console.WriteLine($"Index count is);
            }
            
          
              

            
        }
    }
}
