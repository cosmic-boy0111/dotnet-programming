using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_02.practice
{
    internal class Program07
    {

        static int[,] multiplyMat(int[,] mat1, int[,] mat2)
        {
            int r1 = mat1.GetLength(0);
            int c1 = mat1.GetLength(1);
            int r2 = mat2.GetLength(0);
            int c2 = mat2.GetLength(1);

            int[,] ans = new int[r1, c2];

            int i, j, k;
            for (i = 0; i < r1; i++)
            {
                for (j = 0; j < c2; j++)
                {
                    ans[i, j] = 0;
                    for (k = 0; k < r2; k++)
                        ans[i, j] += mat1[i, k] * mat2[k, j];
                }
            }

            return ans;
        }
        public static void Main()
        {
            int[,] mat1 = { { 1, 1 }, { 2 , 2 } };
            int[,] mat2 = { { 3, 3 }, { 4 , 4 } };

            int[,] result = multiplyMat(mat1, mat2);
            int row = result.GetLength(0);
            int col = result.GetLength(1);
            for(int i = 0; i < row; i++)
            {
                for(int j = 0; j < col; j++)
                {
                    Console.Write("{0} ",result[i, j]);
                }Console.WriteLine();
            }
        }
    }
}
