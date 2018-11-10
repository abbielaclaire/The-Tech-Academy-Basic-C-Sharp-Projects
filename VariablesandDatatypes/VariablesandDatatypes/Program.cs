using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesandDatatypes
{
    class Program
    {
        static void Main(string[] args)
        {
            //This is a simple program
            Console.WriteLine("What is your name?");
            string yourName = Console.ReadLine();
            Console.WriteLine("Your name is: " + yourName);
            Console.ReadLine();

            Console.WriteLine("What is your favorite number?");
            //Casting from int to string
            string favoriteNumber = Console.ReadLine();
            int favNum = Convert.ToInt32(favoriteNumber);
            int total = favNum + 5;
            Console.WriteLine("Your favorite number plus 5 is: " + total);
            Console.ReadLine();

            //Data Types
            bool isStudying = false; //True or False
            byte hoursWorked = 42; //0-255
            sbyte currentTemperature = -32; //negative numbers
            char questionMark = '\u2103';
            Console.WriteLine(questionMark);
            Console.ReadLine();

            decimal moneyInBank = 100.5m;//used only for finacial transactions
            double heightInCentimeters = 211.30202092;
            float secondsLeft = 2.62f;
            short temperatureOnMars = -341;

            int currentAge = 30;
            string yearsOld = currentAge.ToString();

            bool isRaining = true;
            string rainingStatus = Convert.ToString(isRaining);

            Console.WriteLine(rainingStatus);
            Console.ReadLine();



        }
    }
}
