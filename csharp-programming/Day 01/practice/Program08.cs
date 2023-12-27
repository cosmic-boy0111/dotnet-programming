// Count the amount of ones in the binary representation of an integer. For example, since 12 is 1100 in binary, the return value should be 2.


namespace csharp_programming.Day_01.practice
{
    internal class Program08
    {

        static int countOnes(int n)
        {
            int ans = 0;
            string binary = Convert.ToString(n,2);
            foreach(char i in binary){
                if(i == '1') ans++;
            }
            return ans;
        }
        public static void Main()
        {
            Console.Write("Enter Integer : ");
            int n = Convert.ToInt32(Console.ReadLine()); 
            int result = countOnes(n);
            Console.WriteLine("No of ones : {0}",result);
        }
    }
}
