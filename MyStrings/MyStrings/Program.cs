using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyStrings
{
    class Program
    {
        public static void Main(string[] args)
        {

            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("What is your job?");
            string job = Console.ReadLine();
            Console.WriteLine("What state do you live in?");
            string state = Console.ReadLine();
            state = state.ToUpper();
            string[] combo = new String[] {$"Hi {name}, {job} is a nice job, you live in {state}"};
            string combo1 = String.Join(",", combo);
            Console.WriteLine(combo1);

            Console.WriteLine("Let's continue...\n Name three friend's names.");
            string name2 = Console.ReadLine();
            name2 = name2.ToUpper();
            Console.WriteLine($"Let's yell for your friends {name2}! They did not answer us!");
            Console.ReadLine();
            Console.WriteLine("Let's see if we can find them....");

            StringBuilder sb = new StringBuilder();
            
            sb.Append($"Mighty Warrior {name}! \n");
            Console.ReadLine();
            sb.Append($"{name2} have just been arrested.");
            sb.Append($"\n Your position as a {job} makes you the perfect person to help out {name2}.");
            sb.Append($"\n your state {state} will allow you to represent them in court.");
            sb.Append("\n Let's get down to business.");
            Console.WriteLine(sb);
            Console.ReadLine();



        }
    }
}
