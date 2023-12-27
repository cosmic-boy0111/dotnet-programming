// Write a method CalculateArea that takes two optional parameters viz. width and height, and calculates the area of a rectangle. If either parameter is not provided, it should default to 1.

namespace csharp_programming.Day_02.practice
{
    internal class Program01
    {
        static double calculateArea(double width = 1, double height = 1)
        {
            return  width * height;
        }
        public static void Main()
        {
            Console.WriteLine(calculateArea(30, 40));
            Console.WriteLine(calculateArea(30));
            Console.WriteLine(calculateArea());
        }
    }
}
