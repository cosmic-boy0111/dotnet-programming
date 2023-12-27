using System.Runtime.CompilerServices;

namespace csharp_programming
{
    internal class Program08
    {
        public class Vector
        {
            private double x;
            private double y;
            private double z;

            public Vector(double x, double y, double z)
            {
                this.x = x;
                this.y = y;
                this.z = z;
            }

            public static Vector operator +(Vector v, Vector u)
            {
                return new Vector(v.x + u.x , v.y + u.y , v.z + u.z);
            }
            public static Vector operator -(Vector v, Vector u)
            {
                return new Vector(v.x - u.x , v.y - u.y , v.z - u.z);
            }
            public static Vector operator *(Vector v, Vector u)
            {
                return new Vector(v.x * u.x , v.y * u.y , v.z * u.z);
            }

        }

        public static void Main(string[] args)
        {
            Vector v1 = new Vector(1, 2, 3);
            Vector v2 = new Vector(4,5,6);

            Vector w = v1 + v2;

        }
    }
}
