namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DummyBase d = new DummyDerived();
            d.Print();
        }
    }
}

// abstarct class referece can be defined.
