using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Create a program that converts a given 
//amount of money from one currency to another. 
//The program should ask the user to enter the 
//amount of money, the original currency, 
//and the target currency.


namespace csharp_programming
{
    internal class Program05{
        public static void Main()
        {
            Console.Write("Enter Money in Rupee : ");
            double money = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("1. doller");
            Console.WriteLine("2. Japanese Yen");

            int choice = 0;
            Console.Write("Enter your choice : ");
            choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1: Console.WriteLine($"Rupee to doller is {money * 0.012}");
                        break;
                case 2: Console.WriteLine($"Ruppe to Yen is {money * 1.66}");
                        break;
                default: Console.WriteLine("You Enter wrong choice");
                        break;
            }
            
        }
    }
}
