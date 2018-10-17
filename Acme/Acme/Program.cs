using System;

namespace Acme
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome, " + name + " to Acme Accounting Systems!");
            Console.WriteLine("Remember, we're 'Accounting' on you!");
            Console.Read();
        }
    }
}
