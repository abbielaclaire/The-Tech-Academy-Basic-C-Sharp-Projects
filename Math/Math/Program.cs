using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    class Program
    {
        static void Main(string[] args)
        {
            int total = 5 + 10;
            Console.WriteLine("Five plus Ten = " + total.ToString()));
            Console.ReadLine();

            int total = 5 + 10;
            int otherTotal = 12 + 22;
            int combined = total + otherTotal;
            Console.WriteLine(combined);
            Console.ReadLine();

            int difference = 10 - 5;
            Console.WriteLine("Ten minus Five = " + difference.ToString());
            Console.ReadLine();

            int product = 10 * 5;
            Console.WriteLine("Ten times Five= " + product.ToString());
            Console.ReadLine();

            int quotient = 100 / 5;
            Console.WriteLine("One Hundred divided Five = " + quotient.ToString());
            Console.ReadLine();

            int quotient = 100 / 7;
            Console.WriteLine("One Hundred divided by 7 = " + quotient.ToString());
            Console.ReadLine();

            double quotient = 100.0 / 17.0;
            Console.WriteLine("One Hundred divided by seventeen = " + quotient.ToString());
            Console.ReadLine();

            int remainder = 10 % 2;
            Console.WriteLine(remainder);
            Console.ReadLine();

            int remainder = 11 % 2;
            Console.WriteLine(remainder);
            Console.ReadLine();

            bool trueOrFalse = 12 > 5;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();

            bool trueOrFalse = 4 > 5;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();

            int roomTeperature = 70;
            int currentTemperature = 72;
            bool isWarm = currentTemperature > roomTeperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();

            int roomTeperature = 70;
            int currentTemperature = 70;
            bool isWarm = currentTemperature >= roomTeperature;
            Console.WriteLine(isWarm);
            Console.ReadLine();

            int roomTeperature = 70;
            int currentTemperature = 70;
            bool isWarm = currentTemperature == roomTeperature; //! is a NOT, replace the = with ! to reverse the answer is NOT equal
            Console.WriteLine(isWarm);
            Console.ReadLine();
        }
    }
    
    
}
