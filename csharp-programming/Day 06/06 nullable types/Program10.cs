
namespace csharp_programming
{
    internal class Program10
    {
        public static void Main()
        {
            string s = null;
            int length = s?.Length ?? 0;

            s = "Hello, World";
            length = s?.Length ?? 0;
        }
    }
}

/*
 * null coalescing operator can be combined with null-conditional operator
 * to ensure that expression always has a value.
 * Note length is no more nullable typed variable.
 */
