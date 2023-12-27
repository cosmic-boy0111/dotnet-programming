using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_03.practice
{
    internal class Program07
    {
        class ArraySorter
        {
            public static int[] SortDescending(params int[][] arraysContainer)
            {
                int totalSize = 0;
                foreach (var i in arraysContainer){
                    totalSize += i.Length;
                }

                int[] result = new int[totalSize];
                int k = 0;
                foreach (var i in arraysContainer){
                    foreach (var j in i){
                        result[k++] = j;
                    }
                }

                Array.Sort(result);

                return result;

            }
        }

        public static void Main()
        {
            int[] result = ArraySorter.SortDescending(
               new int[] { 71, 30, 18, 76, 91 },
               new int[] { 17, 27, 77, 74, 15 },
               new int[] { 71, 51, 76 },
               new int[] { 78, 4, 94, 87 }
            );

        }
    }

}
