using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstConsoulApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Introduction
            string appName = "Excercise";
            string appVersion = "1";
            string appAuthor = "Alvis Reinbergs";

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("{0}: {1} by {2}", appName, appVersion, appAuthor);

            Console.ResetColor();

            //Question 1
            Console.WriteLine("Whats your Name and Lastname?");

            //Name input
            
            string inputName = Console.ReadLine();

            //Question 2
            Console.WriteLine("Give me a number!");

            //Number input
     
            int number = 0;
            float number2 = 0;
            string numberInput = Console.ReadLine();

            //Looks if its an int or a float (number or decimal)
            while (!(int.TryParse(numberInput, out number) || float.TryParse(numberInput, out number2)))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Not a number");
                Console.ResetColor();
                numberInput = Console.ReadLine();
            }
            
            //Result

            if (int.TryParse(numberInput, out number))
            {
                Console.WriteLine("Hello, {0}. You have entered number {1}", inputName, number);
                
            } else if (float.TryParse(numberInput, out number2))
            {
                Console.WriteLine("Hello, {0}. You have entered number {1}", inputName, number2);
            }
            
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();

         
        }
    }
}
