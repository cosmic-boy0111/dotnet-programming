namespace csharp_programming
{
    internal class DummyDerived : DummyBase{
        public sealed override void Print(){
            base.Print();
            Console.WriteLine("From DummyDerived.Print");
        }
    }
}
