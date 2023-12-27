using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_02.practice
{
    internal class Program02
    {
        static int Fibo(int n)
        {
            if(n == 0 || n == 1) return n;
            return Fibo(n - 1) + Fibo(n - 2);
        }
        public static void Main()
        {
            Console.Write("Enter number to get fibo number : ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Fibonacci number : {Fibo(n)}");
        }
    }
}
