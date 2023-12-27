namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DummyBase b = new DummyDerived();
            b.Print(); // call derived
        }
    }
}

/* 
 * sealed class cannot be inherited futher
 * sealed class cannot have virtual members.
 */