namespace csharp_programming
{
    internal class DummyDerived : DummyBase
    {
        public override void Print(){
            // base.Print(); // cannot call abstact base member
            Console.WriteLine("From DummyDerived.Print");
        }
    }
}
