// Write a recursive function that calculates the greatest common divisor (GCD) of two numbers. The GCD is the largest positive integer that divides both numbers without a remainder.

namespace csharp_programming.Day_02.practice
{
    internal class Program03
    {
        public static void Main()
        {
            Console.Write("Enter first number : ");
            int n1 = Convert.ToInt32(Console.ReadLine()); 
            Console.Write("Enter second number : ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int ans = 1;
            for(int i = 1; i <= Math.Min(n1,n2); i++)
            {
                if(n1 % i == 0 && n2 % i == 0)
                {
                    ans = i;
                }
            }
            Console.WriteLine("GCD : {0}",ans);
        }
    }
}
