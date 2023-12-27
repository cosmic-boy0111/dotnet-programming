namespace csharp_programming
{
    internal class DummyDerived : DummyBase
    {
        new public void Print(){
            Console.WriteLine("From DummyDerived.Print");
        }
    }
}
