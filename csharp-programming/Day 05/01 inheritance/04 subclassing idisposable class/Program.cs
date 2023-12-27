namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            using DummyBase b = new DummyDerived();
        }
    }
}

/*
 * while instantiating derived class, the 
 * constructor of base class is executed first
 * and then constructor of derived class.
 */
