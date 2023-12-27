namespace csharp_programming
{
    internal class Program06
    {
        public class Calculator
        {
            public delegate double MathOperation(double val1, double val2);
            public double Calculate(double val1, double val2, MathOperation operation)
            {
                return operation(val1, val2); ;
            }
        }

        public static double Add(double val1, double val2)
        {
            return val1 + val2;
        }
        public static double Sub(double val1, double val2)
        {
            return val1 - val2;
        }
        public static double Mul(double val1, double val2)
        {
            return val1 * val2;
        }
        public static double Div(double val1, double val2)
        {
            return val1 / val2;
        }

        public static void Main()
        {
            Calculator calculator = new Calculator();
            calculator.Calculate(10, 20, Add);
        }


    }
}
