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

// abstarct methods canot have body
// an abstarct method cannot be a member of non-abstract class
// abstact base members cannot be called.