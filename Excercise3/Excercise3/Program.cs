using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction
            string appName = "Excercise";
            string appVersion = "3";
            string appAuthor = "Alvis Reinbergs";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            //Question
            Console.WriteLine("Enter any number");

            //Number input
            int n = 0;
            int j;

            while (!int.TryParse(Console.ReadLine(), out n))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a number");
                Console.ResetColor();
            }

            for (j = 1; j <= 10; j++)
            {
                Console.Write("{0} X {1} = {2} \n", n, j, n * j);
            }

            //END
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
