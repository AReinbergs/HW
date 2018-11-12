using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction
            string appName = "Excercise";
            string appVersion = "4";
            string appAuthor = "Alvis Reinbergs";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            //Question
            Console.WriteLine("Enter first number");

            //Number input
            int n1 = 0;
            int n2 = 0;
            int n3 = 0;
            int n4 = 0;
            

            while (!int.TryParse(Console.ReadLine(), out n1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a number");
                Console.ResetColor();
            }
            Console.WriteLine("Enter second number");
            while (!int.TryParse(Console.ReadLine(), out n2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a number");
                Console.ResetColor();
            }

            Console.WriteLine("Enter third number");
            while (!int.TryParse(Console.ReadLine(), out n3))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a number");
                Console.ResetColor();
            }
            Console.WriteLine("Enter fourth number");
            while (!int.TryParse(Console.ReadLine(), out n4))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a number");
                Console.ResetColor();
            }

            double[] array = { n1, n2, n3, n4};
            double avg = array.Average();


            Console.WriteLine("The average of {0}; {1}; {2}; {3} is {4}", n1, n2, n3,n4,avg);


            //END
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
