using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Implement a program that generates a Pascal's 
//Triangle of a specified depth. The program should ask 
//the user to enter the desired depth of the triangle 
//and then output the generated triangle.


namespace csharp_programming.Day_01.practice
{
    internal class Practice03
    {
        public static void Main(){

            Console.Write("Enter Depth of pascals triangle : ");
            int depth = Convert.ToInt32(Console.ReadLine());
            int[,] arr = new int[depth + 10, depth + 10];
            for(int i = 0; i < depth + 10; i++)
            {
                for(int  j = 0; j < depth + 10; j++)
                {
                    arr[i,j] = 0;
                }
            }

            arr[1, 1] = 1;
            for(int i = 2; i <= depth + 1; i++){
                for(int j = 1; j < i; j++){
                    arr[i,j] = arr[i-1,j] + arr[i-1,j-1];
                }
            }

            for(int i = 1; i <= depth + 1; i++)
            {
                for(int j = 1; j < i; j++)
                {
                    Console.Write($"{arr[i,j]} ");
                }Console.WriteLine("\n");
            }

            Console.WriteLine("\n");
            Console.ReadLine();
        }
    }
}
