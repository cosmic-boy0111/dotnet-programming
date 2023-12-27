namespace csharp_programming
{
    internal class Program01
    {

        public class Polynomial
        {
            List<double> list = new List<double>();
            public Polynomial(params double[] arr)
            {
                foreach (double i in arr)
                {
                    list.Add(i);
                }
            }

            public double this[int i]
            {
                get { return list[i]; }
            }

            public double Evaluate(double x)
            {
                double result = 0;
                int ind = 0;
                foreach (double i in list)
                {
                    result += this[ind++] * Math.Pow(x,list.Count - ind);
                }

                return result;

            }

        }
        public static void Main()
        {
            Polynomial p = new Polynomial(1,2,3);
            double result = p.Evaluate(2);
        }
    }
}
