namespace csharp_programming
{
    class Interger
    {
        private int value;

        public Interger (int value)
        {
            this.value = value;
        }

        public override bool Equals(Object obj){
            if(obj == null || obj.GetType() != typeof(Interger)) 
                return false;
            Interger other = (Interger)obj;
            return value == other.value;
        }

        public override int GetHashCode(){
            return value % 1000;
        }

    }
    internal class Problem{
        public static void Main()
        {
            Interger u = new Interger(1);
            Interger v = new Interger(1);

            Console.WriteLine(u.Equals(v));
            Console.WriteLine(Object.Equals(u,v));

            Console.WriteLine(u.GetHashCode() == v.GetHashCode());
            Console.WriteLine(Object.ReferenceEquals(u, v));
        }
    }
}

/*
 * GetHashCode is needed when overriding Object.Equals to ensure
 * that objects that are equal have the same hash code.
 */