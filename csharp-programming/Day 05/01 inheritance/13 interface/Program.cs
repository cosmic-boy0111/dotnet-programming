using csharp_programming.Day_05._01_inheritance._13_interface;

namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            IDummyInterface d = new DummyDerived();
            d.HelloProperty = "Hello";
            Console.WriteLine(d.HelloProperty);
            d.Print();
        }
    }
}
