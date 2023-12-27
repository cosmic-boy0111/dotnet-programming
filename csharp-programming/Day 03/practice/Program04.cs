using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming.Day_03.practice
{
    
    internal class Program04
    {
        class Triangle
        {
            double SideA { get; set; }
            double SideB { get; set; }
            double SideC { get; set; }


            public Triangle ( double sideA , double sideB, double sideC ){
                this.SideA = sideA;
                this.SideB = sideB;
                this.SideC = sideC;
            }

            public double GetPerimeter()
            {
                return SideA + SideB + SideC;
            }

            public double GetArea()
            {
                double s = GetPerimeter() / 2;
                return Math.Sqrt(s * (s - SideA) * (s - SideB) * (s - SideC));
            }

        }
        public static void Main(string[] args)
        {
            Triangle T = new Triangle(10 , 15 , 20);
            double perimeter = T.GetPerimeter();
            double area = T.GetArea();
        }
    }
}
