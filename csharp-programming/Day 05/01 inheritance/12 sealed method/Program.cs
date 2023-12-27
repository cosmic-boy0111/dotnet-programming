namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DummyBase b = new DummyDerived();
            b.Print();
        }
    }
}

/* 
 * sealed method cannot be overwritten further.
 */