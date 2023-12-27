// Given an array of integers, return the largest gap between elements of the sorted version of that array. Here's an illustrative example.

namespace csharp_programming.Day_02.practice
{
    internal class Program06
    {
        static int findLargetGap(int[] arr)
        {
            Array.Sort(arr);
            int ans = 0;
            for(int i = 0; i < arr.Length -1; i++)
            {
                ans = Math.Max(ans, arr[i + 1] - arr[i]);
            }

            return ans;
        }
        public static void Main()
        {
            int[] arr = { 9, 4, 26, 26, 0, 0, 5, 20, 6, 25, 5 };
            Console.WriteLine("Larget gap : {0}",findLargetGap(arr));
        }
    }
}
