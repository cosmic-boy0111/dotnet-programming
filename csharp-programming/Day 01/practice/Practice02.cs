using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a program that converts a given temperature from 
//Celsius to Fahrenheit or from Fahrenheit to Celsius. 
//The program should ask the user to enter the 
//temperature and the desired conversion type.

namespace csharp_programming.Day_01.practice
{
    internal class Practice02
    {

        public static void Main()
        {
            Console.Write("Enter Temperature : ");
            double temperature = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Conversions available : ");
            Console.WriteLine("1. Celsius to Fahrenheit");
            Console.WriteLine("2. Fahrenheit to Celsius");
            Console.Write("Enter your choice [1 or 2] : ");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice) { 
                case 1:
                    Console.WriteLine("Conversion in Fahrenheit : {0}", (temperature * 1.8) + 32);
                    break;
                case 2:
                    Console.WriteLine("Conversion in Celsius : {0}", (temperature - 32) / 1.8 );
                    break;
                default:
                    Console.WriteLine("You Entered Wrong Choice : ");
                    break;
            }

        }
    }
}
