
namespace csharp_programming
{

    class Program
    {
        public static T Add<T> (T a, T b)
        {
            dynamic da = a;
            dynamic db = b;
            return da + db;
        }
        public static void Main(string[] args)
        {
            int a = 1, b = 2, c = 0;
            c = Add<int>(a, b);

            double i = 1.2, j = 2.3, k = 0.0;
            k = Add<double>(i, j);
        }
    }
}