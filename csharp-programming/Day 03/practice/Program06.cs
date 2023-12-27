using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_03.practice
{
    internal class Program06
    {
        static int Sum1(int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;   
            }
            return sum;
        }

        static int Sum2(params int[] arr)
        {
            int sum = 0;
            foreach (int i in arr)
            {
                sum += i;
            }
            return sum;
        }

        public static void Main()
        {
            int result = Sum1(new int[] { 1, 2, 3, 4, 5 });
            result = Sum2(1,2,3,4,5,6);

        }
    }
}
