
namespace csharp_programming
{
    internal class DummyDerived : IDummyInterface , IDummyInterface2
    {
        void IDummyInterface.Print() {
            Console.WriteLine("From derived print");
        }
        void IDummyInterface2.Print() {
            Console.WriteLine("From derived print");
        }
    }
}
