using System.Runtime.CompilerServices;

namespace csharp_programming
{
    class Dummy { }

    class Program
    {
        public static void Main()
        {
            dynamic dummy = new Dummy();
            dummy.Foo();
        }
    }
}