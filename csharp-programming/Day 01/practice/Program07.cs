// Create a function that accepts a string of space separated numbers and returns the highest and lowest number (as a string).

using System.Collections.Specialized;

namespace csharp_programming.Day_01.practice
{
    internal class Program07
    {
        static Tuple<int,int> FindMinMax(string s)
        {
            int mn = 100000;
            int mx = -1;
            string[] arr = s.Split(' ');

            foreach (string s2 in arr)
            {
                mn = Math.Min(mn, Convert.ToInt32(s2) );
                mx = Math.Max(mx, Convert.ToInt32(s2) );
            }

            return Tuple.Create(mn, mx);
        }
        public static void Main()
        {
            Console.Write("Enter a list of numbers : ");
            string s = Console.ReadLine(); 
            Tuple<int,int> tuple= FindMinMax(s);
            Console.WriteLine( "minimum : {0}", tuple.Item1);
            Console.WriteLine( "Maximum : {0}",tuple.Item2);
        }
    }
}
