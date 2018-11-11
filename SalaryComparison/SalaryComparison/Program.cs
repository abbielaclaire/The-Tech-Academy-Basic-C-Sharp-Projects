using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalaryComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Program");
            Console.WriteLine("Person 1, Please enter Hourly Rate? Numbers only no dollar signs.");
            decimal rate1 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Person 1, Please enter Hours worked per week?");
            decimal worked1 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Person 2, Please enter Hourly Rate? Numbers only no dollar signs.");
            decimal rate2 = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Person 1, Please enter Hours worked per week?");
            decimal worked2 = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Annual Salary of Person 1:");
            decimal annual1 = rate1 * worked1;
            string money1 = String.Format("{0:C}", annual1);
            Console.WriteLine(money1);
            Console.ReadLine();

            Console.WriteLine("Annual Salary of Person 2:");
            decimal annual2 = rate2 * worked2;
            string money2 = String.Format("{0:C}", annual2);
            Console.WriteLine(money2);
            Console.ReadLine();

            Console.WriteLine("Does Person 1 make more money thatn Person 2?");
            decimal per1 = rate1 * worked1;
            decimal per2 = rate2 * worked2;
            bool isMore = per1 > per2;
            Console.WriteLine(isMore);
            Console.ReadLine();


         

        }
    }
}
