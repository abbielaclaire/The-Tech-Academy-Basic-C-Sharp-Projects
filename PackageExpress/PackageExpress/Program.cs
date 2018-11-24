using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PackageExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            string pkgweight;
            int weightpkg;

            Console.Write("Welcome to Package Express. Please follow the instructions below.");
            Console.ReadLine();
            Console.WriteLine("What is the weight of your package?");
            pkgweight = Console.ReadLine();
            weightpkg = Int32.Parse(pkgweight);

           if (weightpkg < 50)
            {
                Console.WriteLine("Great!");
                Console.ReadLine();
            }

            else
            {
                Console.Write("Sorry your package is to heavy for Package Express.");
                Console.ReadLine();
                return;
            }

            Console.WriteLine("What is the width?");
            string boxwidth = Console.ReadLine();
            int width = Int32.Parse(boxwidth);

            Console.WriteLine("What is the height?");
            string boxHeight = Console.ReadLine();
            int height = Int32.Parse(boxHeight);

            Console.WriteLine("What is the length?");
            string boxLength = Console.ReadLine();
            int length = Int32.Parse(boxLength);

            int sum = (width + height + length);
           
            if (sum > 50)
            {
                Console.Write("Sorry your package is too big to be shipped via Package Express.");
                Console.ReadLine();
                return;
            }
            else
            {
                decimal quote = ((sum * weightpkg) / 100);
                string money1 = String.Format("{0:C}", quote);
                Console.WriteLine("Your shipping cost will be " + money1 + ". Thank you!");
                Console.ReadLine();
            }
        }
    }
}

