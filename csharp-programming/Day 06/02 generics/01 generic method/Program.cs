namespace csharp_programming
{
    internal class Program
    {
        static class Algorithm
        {
            public delegate T Generator<T>();
            public static void Generate<T>(T[] a, Generator<T> gen)
            {
                for(int i = 0; i < a.Length; i++)
                {
                    a[i] = gen();
                }
            }
        }

        class EvenNumberGenerator
        {
            static int value = 0;
            public static int GetNumber()
            {
                int ret = value;
                value += 2;
                return ret;
            }
        }
        class OddNumberGenerator
        {
            static double value = 1;
            public static double GetNumber()
            {
                double ret = value;
                value += 2;
                return ret;
            }
        }
        public static void Main(string[] args)
        {
            int[] a = new int[5];
            Algorithm.Generate(a, EvenNumberGenerator.GetNumber);

            double[] b = new double[5];
            Algorithm.Generate(b, OddNumberGenerator.GetNumber);
        }
    }
}
