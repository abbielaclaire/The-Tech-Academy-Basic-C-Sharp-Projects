using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_while
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guess my favorite wild animal? ");
            string animal = Console.ReadLine();
            bool isGuessed = animal == "wolf";

            do
            {
                switch (animal)
                {
                    case "bobcat":
                        Console.WriteLine("You guessed bobcat, try again.");
                        Console.WriteLine("Guess my favorite animal?");
                        animal = Console.ReadLine();
                        break;
                    case "fox":
                        Console.WriteLine("You guessed fox, try again.");
                        Console.WriteLine("Guess my favorite wild animal?");
                        animal = Console.ReadLine();
                        break;
                    case "dolpin":
                        Console.WriteLine("You guessed dolphin, try again.");
                        Console.WriteLine("Guess my favorite wild animal?");
                        animal = Console.ReadLine();
                        break;
                    default:
                        Console.WriteLine("You guessed incorrect, try again.");
                        Console.WriteLine("Guess my favorite wild animal?");
                        animal = Console.ReadLine();
                        break;
                    case "wolf":
                        Console.WriteLine("You guessed wolf, you are correct.");
                        isGuessed = true;
                        Console.ReadLine();
                        break;
                    case "Wolf":
                        Console.WriteLine("You guessed wolf, you are correct.");
                        isGuessed = true;
                        Console.ReadLine();
                        break;
                }
            }
            while (!isGuessed);

            Console.WriteLine("Lets do some math!! Pick a number between 1-100:");
            int number = Convert.ToInt32(Console.ReadLine());
            

            while (number < 1000)
            {
                
                number = number + 1;
                Console.WriteLine(number);
            }

            Console.WriteLine("We have reached my favorite number 1000");
            Console.ReadLine();

        }
    }
}
