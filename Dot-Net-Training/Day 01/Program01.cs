using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dot_Net_Training.Day_01
{
    internal class Program01
    {
        public static void Main()
        {
            List<int> allNumbers = new List<int>() { 
                14, 47, 74, 78, 85, 96, 69,
                89, 41, 52, 63, 36, 25, 20
            };
            /// collection intializer

            //var myNumbers = (from num in allNumbers
            //                where ((num >= 25 && num <= 85) && num%2 != 0 )
            //                orderby num descending
            //                select num).Take(2);

            //var myNumbers = (from num in allNumbers
            //                 where ((num >= 25 && num <= 85) && num % 2 != 0)
            //                 orderby num descending
            //                 select num).Skip(2).OrderBy(n => n);

            var myNumbers = (from num in allNumbers
                             where ((num >= 25 && num <= 85) && num % 2 != 0)
                             orderby num descending
                             select num).Skip(2).Take(3);

            /// "form" to "select" => LINQ Query

            //foreach ( var num in myNumbers )
            //{
            //    Console.WriteLine($"The Number is : {num}");
            //}

            List<String> allNames = new List<string>()
            {
                "Jojo", "Poapat Lal", "Santa Singh", "Sohan Lal",
                "Banta Singh", "Kk"
            };

            var sortedNames = from nm in allNames
                              where (nm[0] == 's' || nm[0] == 'S') && nm.Length >= 5
                              orderby nm
                              select nm;

            foreach(var item in sortedNames)
            {
                Console.WriteLine($"Names is : {item}");
            }

        }
    }
}
