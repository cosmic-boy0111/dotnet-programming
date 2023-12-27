namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();

            list.Add(1);
            list.Add(2);
            list.Add(3);

            int secondNumber = list[1];

            list.Remove(2);

            foreach (int i in list) { 
                Console.WriteLine(i);
            } 
        }
    }
}

/*
 * In C#, the List<T> class is a generic collection class that is used to
 * store a collection of elements of the same data type T.
 * 
 * List<T> is an implementation of a dynamic array.
 * 
 * It stores elements in contiguous memory locations, which makes accessing
 * elements by index very fast. The size of the array is automatically
 * adjusted as elements are added or removed.
 * 
 * It provides fast access to elements by index and performs well for operations
 * that involve adding or removing elements at the end of the list.
 * 
 * However, inserting or removing elements in the middle of the list can be slow,
 * as it requires shifting all the elements to maintain contiguous memory allocation.
 */
