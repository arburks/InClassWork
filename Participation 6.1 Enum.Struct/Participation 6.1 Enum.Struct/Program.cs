using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Participation_6._1_Enum.Struct
{
    //by Austin Burks
    //Default enum orientation is Int32
    enum Orientation
    {
        North = 1,
        South = 2,
        East = 3,
        West = 4
    }

    struct Route
    {
        public Orientation direction;
        public double distance;
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Orientation myDirection = Orientation.North;
            //Orientation antoherDirection = Orientation.South;
            //Random randomNumber = new Random();

            //WriteLine($"myDirection = {myDirection}");

            Route myRoute;
            int myDirection = -1;
            double myDistance;
            WriteLine("1) North\n2) South\n3) East\n4) West");

            do
            {
                WriteLine("Select a Direction:");
                myDirection = ToInt32(ReadLine());
            } while ((myDirection < 1) || (myDirection > 4));

            WriteLine("Input a distance:");
            myDistance = ToDouble(ReadLine());
            myRoute.direction = (Orientation)myDirection;
            myRoute.distance = myDistance;
            WriteLine($"myRoute specifies a direction of {myRoute.direction} and a distance of {myRoute.distance}");

            WriteLine("");
            WriteLine("Press any key to exit ... ");
            ReadKey();

        }
    }
}
