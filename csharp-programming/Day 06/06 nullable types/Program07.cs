
namespace csharp_programming
{
    internal class Program07
    {
        public static void Main()
        {
            int? i = 5;
            int? j = i * 5 ?? 5;

            i = null;
            j = i * 5 ?? 5;
        }
    }
}

/*
 * use Value property to assign nullable object value to non-nullable
 * variables.
 * operations on nullable object is possible
 */
