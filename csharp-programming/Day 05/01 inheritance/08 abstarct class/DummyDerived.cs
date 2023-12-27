namespace csharp_programming
{
    internal class DummyDerived : DummyBase
    {
        public override void Print(){
            base.Print(); // invokes dummy base print()
            Console.WriteLine("From DummyDerived.Print");
        }
    }
}
