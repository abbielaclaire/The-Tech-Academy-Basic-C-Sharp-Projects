using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess a number?");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isGuessed = number == 12;

            do
            {
                switch (number)
                {
                    case 60:
                        Console.WriteLine("You guessed 60, try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 30:
                        Console.WriteLine("You guessed 30, try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 55:
                        Console.WriteLine("You guessed 55, try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    default:
                        Console.WriteLine("You guessed incorrect, try again.");
                        Console.WriteLine("Guess a number?");
                        number = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 12:
                        Console.WriteLine("You guessed 12, you are correct.");
                        isGuessed = true;
                        Console.ReadLine();
                        break;
                }
            }
            while (!isGuessed); //the "!" is the same as writing isGuessed ==False
            {
                ////this is a while loop 
                ////
                //switch (number)
                //{
                //    case 60:
                //        Console.WriteLine("You guessed 60, try again.");
                //        Console.WriteLine("Guess a number?");
                //        number = Convert.ToInt32(Console.ReadLine());
                //        break;
                //    case 30:
                //        Console.WriteLine("You guessed 30, try again.");
                //        Console.WriteLine("Guess a number?");
                //        number = Convert.ToInt32(Console.ReadLine());
                //        break;
                //    case 55:
                //        Console.WriteLine("You guessed 55, try again.");
                //        Console.WriteLine("Guess a number?");
                //        number = Convert.ToInt32(Console.ReadLine());
                //        break;
                //    default:
                //        Console.WriteLine("You guessed incorrect, try again.");
                //        Console.WriteLine("Guess a number?");
                //        number = Convert.ToInt32(Console.ReadLine());
                //        break;
                //    case 12:
                //        Console.WriteLine("You guessed 12, you are correct.");
                //        isGuessed = true;
                //        Console.ReadLine();
                //        break;
                //}
            }
        }
    }
}
