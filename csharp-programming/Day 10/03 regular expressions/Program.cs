using System.Diagnostics;

namespace csharp_programming.Day_10._03_regular_expressions
{
    enum TemperaturUnit
    {
        Celsius,
        Fahrenheit
    }

    public static class ArrayExtensions
    {
        public static T[] GetRange<T>(T[] array, int startIndex, int length)
        {
            if (startIndex < 0 || startIndex >= array.Length)
            {
                throw new Exception("starIndex is not valid parameter");
            }

            if (length < 0 || startIndex + length > array.Length)
            {
                throw new Exception("Length is not valid parameter");
            }

            T[] result = new T[length];
            int j = 0;
            for(int i = startIndex; i < startIndex + length; i++)
            {
                result[j++] = array[i];
            }
            return result;
        }
    }

    class Program03
    {
        
        public class Temperature
        {
            public double Value { get; set; }
            public TemperaturUnit Unit { get; set; }

            public void ConvertTo( TemperaturUnit unit )
            {
                if(unit == TemperaturUnit.Celsius)
                {
                    Unit = TemperaturUnit.Celsius;
                    Value = (Value - 32) * 5 / 9;
                }
                else
                {
                    Unit = TemperaturUnit.Fahrenheit;
                    Value = Value * 9 / 5 + 32;
                }

            }

            

        }

        







        public static void Main(string[] args)
        {
            StreamReader sr = new StreamReader("numbers.txt");
            string line;
            line = sr.ReadLine();
            int sum = 0;
            while (line != null)
            {
                sum += Convert.ToInt32(line);
                line = sr.ReadLine();
            }
            Console.WriteLine($"sum of numbers present in file is : {sum}");
            sr.Close();

            int i = Convert.ToInt32(true);

        }
    }
}
