
namespace csharp_programming
{
    internal class Program05
    {
        public static void Main()
        {
            int? i = 5;
            int? j = i * 5;
            int k = j.Value;
        }
    }
}

/*
 * use Value property to assign nullable object value to non-nullable
 * variables.
 * operations on nullable object is possible
 */
