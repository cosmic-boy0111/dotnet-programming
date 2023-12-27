using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implement a program that reads a list of 
//integers from the console and calculates the 
//median value of the list. The median value is 
//the middle value when the list is sorted in ascending order.


namespace csharp_programming.Day_01.practice
{
    internal class Program04{
        public static void Main()
        {
            Console.Write("Enter number of values : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter numbers : ");
            for(int i = 0; i < n; i++){
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            // 1 2 3 4 5 6
            Array.Sort(arr);
            if(n%2 == 1){
                Console.WriteLine($"Median is : {arr[n/2]}");
            }
            else { Console.WriteLine($"Median is : {(arr[n / 2] + arr[n / 2 - 1]) / 2}"); }
            Console.ReadLine();
        }
    }
}
