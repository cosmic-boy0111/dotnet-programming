
namespace csharp_programming
{
    internal class DummyDerived : DummyBase ,IDummyInterface , IDummyInterface2
    {
        void IDummyInterface.Print() {
            Console.WriteLine("From interface1 print");
        }
        void IDummyInterface2.Print() {
            Console.WriteLine("From interface2 print");
        }

        public override void Print()
        {
            Console.WriteLine("From derved print");
        }
    }
}

/*
 * C# support single class inheritance and
 * single or multiple interface inheritance
 * if class is derived form another class and interface
 * then class should be mentioned first and then interface(s);
 */
