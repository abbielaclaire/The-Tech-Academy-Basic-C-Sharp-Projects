using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DailyInquiryStudent
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("The Tech Academy");
            Console.WriteLine("Student Daily Report");

            //student's cours and page
            Console.WriteLine("What Course are you on?");
            string course = Console.ReadLine();
            Console.WriteLine("What page number or step number are you on?");
            string pageNumber = Console.ReadLine();


            //need help
            Console.WriteLine("Do you need help with anything? Please answer 'true' or 'false'");
            string help = Console.ReadLine();

            bool val = Convert.ToBoolean(help);

            if (val == true)
            {
                Console.WriteLine("An Instructor will contact you soon.");
            }

            else
            {
                Console.WriteLine("Keep up the great work!");
            }
            Console.ReadLine();


            //Study hours
            Console.WriteLine("How many hours did you study today?");
            string study = Console.ReadLine();
            string hours = study.ToString();

            //Experiences
            Console.WriteLine("Were there any positive experiences you'd like to share? Please give specifics.");
            string experiences = Console.ReadLine();
            Console.WriteLine("Is there any other feedback you'd like to provide? Please be speific.");
            string feedback = Console.ReadLine();

            //Close
            Console.WriteLine("Thank you for your answers. An instructor will responf to this shortly. Have a Great Day!");
            Console.ReadLine();


        }
        }




    }

