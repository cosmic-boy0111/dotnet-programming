namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            object a = 1;

            int i = 5;
            object b = 1;
            i += 10; // note the value contained in the box didin't change
        }
    }
}


/*
 * When the CLR boxes a value type, it wraps the value inside a
 * System.Object and stores it on the managed heap.
 * Boxing is implicit.
 */