
namespace csharp_programming
{
    internal class Program09
    {
        public static void Main()
        {
            string s = null;
            int? length = s?.Length;

            s = "Hello, World";
            length = s?.Length;
        }
    }
}

/*
 * ?. is known as Null-Conditional operator
 * it returns null if s null else return the length of the string
 */
