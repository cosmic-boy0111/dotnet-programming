using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// Create a function that determines whether elements in an array can be rearranged to form a consecutive list of numbers where each number appears exactly once.

namespace csharp_programming.Day_02.practice
{
    internal class Program10
    {
        static bool Cons(int[] arr)
        {
            Array.Sort(arr);

            for(int i = 0; i < arr.Length - 1; i++)
            {
                if (arr[i + 1] != arr[i] + 1) return false;
            }

            return true;
        }
        public static void Main()
        {
            bool result = Cons(new int[] { 5, 1, 4, 3, 2 });
            result = Cons(new int[] { 5, 1, 4, 3, 2, 8 });
            result = Cons(new int[] { 5, 6, 7, 8, 9, 9 });
        }
    }
}
