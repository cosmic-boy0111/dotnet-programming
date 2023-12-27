using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Write a program that checks whether a given 
//string is a palindrome or not. A palindrome is a word, 
//phrase, number, or other sequence of characters that 
//reads the same forward and backward.

namespace csharp_programming
{
    internal class Practice01{

        static bool isPalindrome(string s){

            string temp = s.ToLower();
            for(int i = 0; i < temp.Length / 2; i++)
            {
                if (temp[i] != temp[temp.Length - i - 1]) return false;
            }

            return true;

        }
        public static int Main(){

            string s = "";
            Console.Write("Enter a string : ");
            s = Console.ReadLine();

            bool result = isPalindrome(s);
            if (result)
            {
                Console.WriteLine($"{s} is palindrome");
            }
            else
            {
                Console.WriteLine($"{s} is not palindrome");
            }


            return 0;
        }
    }
}
