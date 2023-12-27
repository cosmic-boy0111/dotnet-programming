namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            DummyDerived d = new DummyDerived();
        }
    }
}

/*
 * while instantiating derived class, the 
 * constructor of base class is executed first
 * and then constructor of derived class.
 */
