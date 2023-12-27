using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_01.practice
{
    internal class Program06
    {

        static bool isPalindrome(int n)
        {
            string s = n.ToString();
            for(int i = 0; i < s.Length /2; i++)
            {
                if (s[i] != s[s.Length - i - 1]) return false;
            }
            return true;
        }
        public static void Main()
        {
            Console.Write("Enter a digit : ");
            int n = Convert.ToInt32(Console.ReadLine());
            int upper_limit = (int)Math.Pow(10, n) - 1;
            int lower_limit = 1 + upper_limit / 10;
            int max_product = 0;
            for (int i = upper_limit; i >= lower_limit; i--)
            {
                for (int j = i; j >= lower_limit; j--)
                {
                    int product = i * j;
                    if (product < max_product)
                        break;
                    int number = product;
                    int reverse = 0;

                    while (number != 0)
                    {
                        reverse = reverse * 10 +
                                  number % 10;
                        number /= 10;
                    }

                    if (product == reverse &&
                        product > max_product)

                        max_product = product;
                }
            }

            Console.WriteLine($"The laregest palindrome is : {max_product}");

        }
    }
}
