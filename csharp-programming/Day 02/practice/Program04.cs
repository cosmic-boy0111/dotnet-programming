// Write two methods called Area that calculate the area of a rectangle. One method should take two parameters, width and height, while the other should take one parameter, length, which represents the length of one side of a square.

using System.Transactions;

namespace csharp_programming.Day_02.practice
{
    internal class Program04
    {
        static double Area(double height,double width)
        {
            return height * width;
        }
        static double Area(double length)
        {
            return 4 * length;
        }

        public static void Main()
        {
            Console.WriteLine("Area of reactangle {0}", Area(34, 12));
            Console.WriteLine("Area of Square {0}", Area(10));
        }
    }
}
