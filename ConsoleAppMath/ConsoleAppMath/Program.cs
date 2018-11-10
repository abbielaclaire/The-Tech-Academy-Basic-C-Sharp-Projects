using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppMath
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Pick a whole number.");
            long input = long.Parse(Console.ReadLine());
            long product = input * 50;
            Console.WriteLine(product);
            Console.ReadLine();

            Console.WriteLine("Pick a whole number.");
            long num1 = long.Parse(Console.ReadLine());
            long total = num1 + 25;
            Console.WriteLine(total);
            Console.ReadLine();


            Console.WriteLine("Pick a number");
            double num2 = double.Parse(Console.ReadLine());
            double quotient = num2 / 12.5;
            Console.WriteLine(quotient);
            Console.ReadLine();


            Console.WriteLine("Pick a number");
            double num3 = double.Parse(Console.ReadLine());
            int comNum = 50;
            bool number = num3 > comNum;
            Console.WriteLine(number);
            Console.ReadLine();

            Console.WriteLine("Pick a number");
            double num4 = double.Parse(Console.ReadLine());
            double remainder = num4 % 2;
            Console.WriteLine(remainder);
            Console.ReadLine();

        }
    }
}
