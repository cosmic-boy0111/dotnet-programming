using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Given an array of random digits of any length, return true if the number n appears times times in a row, and false otherwise.

namespace csharp_programming.Day_02.practice
{
    internal class Program09
    {
        static bool IsThereConsecutive(int[] arr,int item,int times)
        {
            if (times == 0) return true;
            int temp_times = 0;
            bool pre = false;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == item)
                {
                    if (pre) { temp_times++; }
                    else temp_times = 1;
                    pre = true;

                    if (temp_times == times) return true;
                }
                else pre = false;
            }

            return false;
        }
        public static void Main()
        {
            bool res = IsThereConsecutive(new int[] { 1, 2, 3, 4, 5 }, 1, 1);
            res = IsThereConsecutive(new int[] { 3 }, 1, 0);
            res = IsThereConsecutive(new int[] { 2, 2, 3, 2, 2, 2, 2, 3, 4, 1, 5 }, 3, 2);
            res = IsThereConsecutive(new int[] { 5, 5, 5, 5, 5 }, 5, 7);

        }
    }
}
