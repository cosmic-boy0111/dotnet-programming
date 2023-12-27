
namespace csharp_programming
{
    internal class Program03
    {
        public static void Main()
        {
            Resistor r1 = new Resistor(100);
            Resistor r2 = new Resistor(100);
            Resistor r3 = new Resistor(50);
            Resistor r4 = new Resistor(200);

            ParallelRegister p = new ParallelRegister();
            p.Add(r3); 
            p.Add(r4);

            SeriesRegister s = new SeriesRegister();
            s.Add(r1);
            s.Add(r2);
            s.Add(p);

            Console.WriteLine(s.GetRegistance());
        }
    }
}
