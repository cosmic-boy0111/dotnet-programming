using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Implement a binary search algorithm in C#. The program should ask the user to enter a target number and search for that number in a sorted array of integers.
namespace csharp_programming.Day_02.practice
{
    internal class Program08
    {

        static int BinarySearch(int[] arr,int ele)
        {
               
            int low = 0; 
            int high = arr.Length - 1;

            while (low <= high)
            {
                int mid = low+ (high - low) / 2;
                if (arr[mid] == ele)
                {
                    return mid;
                }
                if (arr[mid] > ele)
                {
                    high = mid - 1;
                }
                else
                {
                    low = mid + 1;
                }
            }

            return -1;
        }
        public static void Main()
        {
            int[] arr = {  4, 5, 6, 9, 10, 15, 20, 25, 26, 29, 40};
            Console.Write("Enter Element to search : ");
            int ele = Convert.ToInt32(Console.ReadLine());
            int result = BinarySearch(arr, ele);
            if (result == -1) Console.WriteLine("Element not present : ");
            else Console.WriteLine($"Element present at index {result}");
        }
    }
}
