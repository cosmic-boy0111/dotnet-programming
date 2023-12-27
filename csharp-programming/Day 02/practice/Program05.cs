// Create a function that takes two numbers as arguments (num, length) and returns an array of multiples of num until the array length reaches length.

namespace csharp_programming.Day_02.practice
{
    internal class Program05
    {
        static int[] generate(int num,int length)
        {
            int[] ans = new int[length];
            for(int i = 1; i <= length; i++)
            {
                ans[i - 1] = num * i;
            }
            return ans;
        }
        public static void Main()
        {
            Console.Write("Enter a number : ");
            int num  = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a length : ");
            int length  = Convert.ToInt32(Console.ReadLine());

            int[] arr = generate(num, length);
            for(int i = 0; i < arr.Length; i++)
            {
                Console.Write("{0} ",arr[i]);
            }
        }
    }
}
