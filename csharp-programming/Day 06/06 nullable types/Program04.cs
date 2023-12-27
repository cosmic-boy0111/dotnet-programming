
namespace csharp_programming
{
    internal class Program04
    {
        public static void Main()
        {
            int? i = null;
            int? j = 10;
            bool b = i.HasValue;
            b = j.HasValue;
        }
    }
}

/*
 * HasValue indicates if nullable type object has underlying value or not
 * Return true if has value
 */
