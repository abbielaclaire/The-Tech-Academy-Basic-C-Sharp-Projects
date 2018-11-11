using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Branching
{
    class Program
    {
        static void Main(string[] args)
        {

            //int currentTemperature = 85;
            //int roomTemperature = 70;

            //string comparisonResult = currentTemperature == roomTemperature ? "It is room Temp." : "It is not room Temp."; //if -else statement shorthand
            //Console.WriteLine(comparisonResult);
            //if (currentTemperature == roomTemperature)
            //{
            //    Console.WriteLine("it is exactly room temperature!");
            //}

            //else if (currentTemperature > roomTemperature)
            //{
            //    Console.WriteLine("it is warmer than room temperature");
            //}
            //else if (currentTemperature < roomTemperature)
            //{
            //    Console.WriteLine("it is colderr than room temperature");
            //}

            //else
            //{
            //    Console.WriteLine("it is not exactly room temperature.");
            //}

            //Console.ReadLine();


            //int roomtemperature = 70;

            //Console.WriteLine("What is your name?");
            //string name = Console.ReadLine();

            //Console.WriteLine("Hi, " + name + ", what is the temperature where you are?");
            //int currentTemperature = Convert.ToInt32(Console.ReadLine());

            //if (currentTemperature == roomtemperature)
            //{
            //    Console.WriteLine("It is exactly room temperature.");
            //}
            //else if (currentTemperature > roomtemperature)
            //{
            //    Console.WriteLine("It is warmer than room temperature.");
            //}
            //else if (currentTemperature < roomtemperature)
            //{
            //    Console.WriteLine("It is colder than room temperature");
            //}
            //else
            //{
            //    Console.WriteLine("Uuuuhhh..Something went wrong!!");
            //}
            //Console.ReadLine();


            Console.WriteLine("What is your favorite number?");
            int favNum = Convert.ToInt32(Console.ReadLine());

            string result = favNum == 12 ? "You have an awesome favorite number." : "You do not have an awesome favorit number. Sadness!";

            Console.WriteLine(result);
            Console.ReadLine();




        }
    }
}
