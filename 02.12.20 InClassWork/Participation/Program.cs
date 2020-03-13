using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<double>> courseGrade = new Dictionary<string, List<double>>();
            List<double> listofnum = new List<double>() { 98, 50, 60, 55, 89 };
            List<double> listofnum1 = new List<double>() { 88, 70, 69, 96, 79 };
            List<double> listofnum2 = new List<double>() { 99, 89, 88, 76, 91 };

            courseGrade.Add("mis3013", new List<double>());
            courseGrade["mis3013"].AddRange(listofnum);

            courseGrade.Add("acct2013", new List<double>());
            courseGrade["acct2013"].AddRange(listofnum1);

            courseGrade.Add("econ2213", new List<double>());
            courseGrade["econ2213"].AddRange(listofnum2);
            courseGrade["econ2213"].Add(56);

            foreach (var courseCode in courseGrade.Keys)
            {
                double sum = 0;

                foreach (var grade in courseGrade[courseCode])
                {
                    sum += grade;
                }
                double sumAsPercent = sum / 100;
                var count = sumAsPercent / courseGrade[courseCode].Count;
                Console.WriteLine($"The average for {courseCode} is {count.ToString("P")}");
                
            }
          
            Console.ReadKey();
        }   
    }
}
