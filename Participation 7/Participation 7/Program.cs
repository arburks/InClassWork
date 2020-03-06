using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation_7
{
    class Program
    {
        //coded by Austin Burks
        static void Main(string[] args)
        {
            string[] subjects = new string[3];
            int[] crns = new int[3];

            for (int i = 0; i < crns.Length; i++)
            {
                Console.WriteLine($"Please enter the subject for the course {i + 1} >>");
                string subject = Console.ReadLine();
                subjects[i] = subject;

                Console.WriteLine($"Please enter the course number for course {i + 1} >>");
                crns[i] = Convert.ToInt32(Console.ReadLine());
            }

            int x = 0;

            while (x < crns.Length)
            {
                Console.WriteLine($"{subjects[x]}{crns[x]}");

                x++;
            }

            Console.ReadKey();

            List<double> grades = new List<double>();
            string answer = string.Empty;

            do
            {
                Console.WriteLine("Please enter your grade >>");
                string gradeAsAString = Console.ReadLine();
                double grade;
                while (double.TryParse(gradeAsAString, out grade) == false)
                {
                    Console.WriteLine("Invalid entry, please try again");
                    Console.WriteLine("Please enter your grade >>");
                    gradeAsAString = Console.ReadLine();
                }

                grades.Add(grade);
                Console.WriteLine("Do you have another grade? yes or no");
                answer = Console.ReadLine().ToUpper().Trim();
            } while (answer != "NO");

            double sum = 0;

            foreach (double grade in grades)
            {
                sum += grade;
            }

            double average = sum / grades.Count;

        }
    }
}
