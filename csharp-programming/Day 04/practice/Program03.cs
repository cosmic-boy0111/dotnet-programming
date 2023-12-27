using System.Security.Cryptography.X509Certificates;

namespace csharp_programming{ 
    internal class Program03{


        public class Triangle
        {
            double a = 0;
            double b = 0;
            double c = 0;
            public Triangle(params double[] sides)
            {
                a = sides[0]; 
                b = sides[1]; 
                c = sides[2];
            }


            public double this[string name]
            {
                get
                {
                    double result = 0;
                    switch (name)
                    {
                        case "a":
                            result = a;
                            break;
                        case "b": 
                            result = b;
                            break;
                        case "c": 
                            result = c;
                            break;
                    }
                    return result;
                }
            }

            public double Area()
            {
                double perimeter = (this["a"] + this["b"] + this["c"]) / 2;
                return  Math.Sqrt(perimeter * (perimeter - this["a"]) * (perimeter - this["b"]) * (perimeter - this["c"]));
            }

        }
        public static void Main(string[] args)
        {
            Triangle t = new Triangle(new double[] { 20, 40, 30 });
            double result = t.Area();
        }
    }
}
