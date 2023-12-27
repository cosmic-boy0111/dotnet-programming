
namespace csharp_programming
{
    public class Resistor : IResistor
    {
        private double register = 0;
        public Resistor(double register)
        {
            this.register = register;
        }
        public double GetRegistance()
        {
            return register;
        }
    }
}
