
namespace csharp_programming
{
    class Program
    {
        static double SafeDivision(double x , double y)
        {
            if (y == 0)
                throw new System.DivideByZeroException();
            return x / y;
        }

        public static void Main(string[] args)
        {
            double x = 98, y = 10;
            double result = 0;

            try
            {
                result = SafeDivision(x, y);
                Console.WriteLine($"{x} divided by {y} = {result}");
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}