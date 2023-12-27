namespace csharp_programming
{
    class Interger
    {
        private int value;

        public Interger (int value)
        {
            this.value = value;
        }

        public bool Equals(Interger obj)
        {
            return value == obj.value;
        }

    }
    internal class Problem{
        public static void Main()
        {
            Interger u = new Interger(1);
            Interger v = new Interger(1);

            Console.WriteLine(u.Equals(v));
            Console.WriteLine(Object.Equals(u,v));
        }
    }
}

/*
 * The default implementation of Equals compares objects by address.
 * As a result, two distict objects have the same value when compared with Equals,
 * returns false.
 */