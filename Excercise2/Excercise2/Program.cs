using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction
            string appName = "Excercise";
            string appVersion = "2";
            string appAuthor = "Alvis Reinbergs";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            //Variable 1
            Console.WriteLine("Enter the first variable");

            int var1 = 0;
            while (!int.TryParse(Console.ReadLine(), out var1))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a number");
                Console.ResetColor();
            }

            //Variable 2
            Console.WriteLine("Enter the second variable");

            int var2 = 0;
            while (!int.TryParse(Console.ReadLine(), out var2))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a number");
                Console.ResetColor();
            }

            //Befoer
            Console.WriteLine("Your first variable is {0} and your second variable is {1}", var1, var2);

            //SWAP
            int temp = var1;
            var1 = var2;
            var2 = temp;

            //AFTER
            Console.WriteLine("Your first variable now is {0} and your second variable now is {1}", var1, var2);

            //END
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
