// Create a function that takes any non-negative number as an argument and return it with its digits in descending order. Descending order is when you sort from highest to lowest.
using System.Collections.Specialized;

namespace csharp_programming.Day_01.practice
{
    internal class Program09
    {
        private static int OrderDigits(int number, bool asc)
        {
            int[] digits = new int[(int)Math.Floor(Math.Log10(Math.Abs(number)) + 1)];
            for (int i = 0; i < digits.Length; i++)
            {
                digits[i] = number % 10;
                number /= 10;
            }
            for (int i = 0; i < digits.Length; i++)
            {
                for (int j = i + 1; j < digits.Length; j++)
                {
                    if ((!asc && digits[j] > digits[i]) ||
                        (asc && digits[j] < digits[i]))
                    {
                        int temp = digits[i];
                        digits[i] = digits[j];
                        digits[j] = temp;
                    }
                }
            }
            int result = 0;
            for (int i = digits.Length - 1; i >= 0; i--)
            {
                result += digits[i] * (int)Math.Pow(10, digits.Length - 1 - i);
            }

            return result;
        }
        public static void Main()
        {
            Console.Write("Enter digit : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Sorted digits : {OrderDigits(n, false)}");
        }
    }
}
