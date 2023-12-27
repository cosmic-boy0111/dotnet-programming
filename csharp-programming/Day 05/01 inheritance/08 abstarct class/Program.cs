namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DummyBase b = new DummyBase();
            b.Print(); // call derived
        }
    }
}

// abstarct class object cannot be created
