
namespace csharp_programming
{
    public class SeriesRegister : RegisterCollection
    {

        

        public override double GetRegistance()
        {
            double effective_register = 0;
            foreach (IResistor register in registers)
            {
                effective_register += register.GetRegistance();
            }
            return effective_register;
        }
    }
}
