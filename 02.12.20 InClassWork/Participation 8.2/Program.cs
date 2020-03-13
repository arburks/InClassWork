using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation_8._2
{
    class Program
    {
        static void Main(string[] args)
        {
            var favoriteThings = new List<string>();
            string answer;
            do
            {
                Console.WriteLine("Please enter one of your favorite things >>");
                favoriteThings.Add(Console.ReadLine());

                Console.WriteLine("Do you have another favorite thing to add? Y/N >>");
                answer = Console.ReadLine().ToUpper()[0].ToString();
            }
            while (answer != "N");

            Random random = new Random();
            int randomNumber = random.Next(0, (favoriteThings.Count()-1));
            Console.WriteLine($"Favorite thing { favoriteThings[randomNumber] }");

            Console.ReadLine();

            Dictionary<int, double> studentGrades = new Dictionary<int, double>();
            studentGrades.Add(10, 3.8);
            studentGrades.Add(11, 3.9);
            studentGrades.Add(12, 3.4);

            Console.WriteLine("Please pick a student ID to see their GPA: ");
            int userInput = Convert.ToInt32(Console.ReadLine());

            if(studentGrades.ContainsKey(userInput))
            {
                Console.WriteLine($"The student with ID {userInput} has a GPA of {studentGrades[userInput]}");
            }
            else
            {
                Console.WriteLine("Sorry, you entered an invalid ID. I award you no points and may God have mercy on your soul. Goodbye!!");
            }
 
        }
    }
}
