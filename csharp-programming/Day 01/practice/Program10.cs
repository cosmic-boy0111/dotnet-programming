using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_01.practice
{
    internal class Program10
    {
        static string FindNemo(string s)
        {
            string[] arr = s.Split(' ');
            int index = -1;
            for(int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == "Nemo")
                {
                    index = i + 1;
                    break;
                }
            }
            if (index != -1) return $"I found Nemo at {index}!";
            return "I can't find Nemo :(";
        }
        public static void Main()
        {
            Console.Write("Enter string : ");
            string s = Console.ReadLine();
            Console.WriteLine(FindNemo(s));
        }
    }
}
