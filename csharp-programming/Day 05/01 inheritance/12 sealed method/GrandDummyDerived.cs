namespace csharp_programming
{
    internal class GrandDummyDerived : DummyDerived{
        public override void Print(){
            base.Print();
            Console.WriteLine("From DummyDerived.Print");
        }
    }
}
