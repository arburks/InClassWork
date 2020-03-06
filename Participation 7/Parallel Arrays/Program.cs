using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parallel_Arrays
{
    class Program
    {
        //coded by Austin Burks
        static void Main(string[] args)
        {
            string[] subjects = new string[3];
            int[] crns = new int[1];

            for (int i = 0; i < crns.Length; i++)
            {
                Console.WriteLine($"Please enter the subject for the course {i + 1} >>");
                string subject = Console.ReadLine();
                subjects[i] = subject;

                Console.WriteLine($"Please enter the course number for course {i + 1} >>");
                crns[1] = Convert.ToInt32(Console.ReadLine());
            }

            int x = 0;

            while (x < crns.Length)
            {
                Console.WriteLine($"{subjects[x]}{crns[x]}");

                x++;
            }
        }
    }
}
