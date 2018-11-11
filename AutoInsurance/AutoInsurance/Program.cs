using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoInsurance
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Looking for Auto Insurance? Answer some questions to see if you qualify:");
            Console.WriteLine("What is your age?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Have you ever had a DUI? Yes or No?");
            string drunk = Console.ReadLine();
           
            Console.WriteLine("How many speeding tickets do you have?");
            int tix = int.Parse(Console.ReadLine());

            bool qualify = ((age > 15) && (tix < 3) && (drunk == "No"));

            Console.WriteLine(qualify);
                                  
            if (qualify == true)
            {
                Console.WriteLine("Congratulations!! You can get Auto Insurance.");
            }

            else
            {
                Console.WriteLine("Better Luck next Time!");
            }
            Console.ReadLine();


            

           

        }
    }
}
