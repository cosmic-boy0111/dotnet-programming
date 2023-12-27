namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DummyBase b = new DummyDerived();
            b.Print(); // call derived
            DummyDerived d = new DummyDerived();
            d.Print(); // call derived
        }
    }
}
