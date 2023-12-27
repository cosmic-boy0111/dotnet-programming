
namespace csharp_programming
{

    class Program
    {
        public static dynamic Add(dynamic a, dynamic b)
        {
            return a + b;
        }
        public static void Main(string[] args)
        {
            int a = 1, b = 2, c = 0;
            c = Add(a, b);

            double i = 1.2, j = 2.3, k = 0.0;
            k = Add(i, j);
        }
    }
}