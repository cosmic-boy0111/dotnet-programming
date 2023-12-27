
namespace csharp_programming
{
    public abstract class RegisterCollection : IResistor{

        private protected List<IResistor> registers = new List<IResistor>();

        public  void Add(IResistor register)
        {
            registers.Add(register);
        }
        public abstract double GetRegistance();
    }
}
