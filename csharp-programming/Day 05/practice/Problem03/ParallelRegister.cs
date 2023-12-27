
namespace csharp_programming
{
    public class ParallelRegister : RegisterCollection
    {
        public override double GetRegistance()
        {
            double effective_register = 0;

            foreach (IResistor register in registers)
            {
                effective_register += 1 / register.GetRegistance();
            }

            return 1 / effective_register;
        }
    }
}
