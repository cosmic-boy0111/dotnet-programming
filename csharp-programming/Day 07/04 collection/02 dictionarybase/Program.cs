
using System.Collections;

namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyDictionary d = new MyDictionary();
            d.Add(1, "Item 1");
            d.Add(2, "Item 2");
            d.Add(3, "Item 3");

            d.Remove(1);

            foreach (DictionaryEntry item in d)
            {
                Console.WriteLine($"{item.Key} = {item.Value}");
            }

        }
    }
}

/*
 * DictionaryBase is an abstract base class in C# that provides a basic
 * implementation of the IDictionary interface. It's similar to CollectionBase,
 * but provides key-value pairs instead of just a list of objects.
 * 
 * The Dictionary property of DictionaryBase is a Hashtable object that represents
 * the actual dictionary. Dictionary.Add and Dictionary.Remove are used to add and
 * remove key-value pairs from the dictionary. Dictionary[key] is used to get or
 * set values associated with keys in the dictionary.
 * 
 * As with CollectionBase, DictionaryBase is considered a legacy collection class
 * in .NET Framework, and it's recommended to use generic collection classes such
 * as Dictionary<TKey, TValue> instead.
 */
