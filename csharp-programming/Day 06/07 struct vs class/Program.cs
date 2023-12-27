namespace csharp_programming
{
    struct Interger
    {
        public int n;
        public Interger()
        {
            n = 0;
        }

        public Interger(int i) { n = i; }

        public void this[int i] {
        }

        public void this[string i]
        {

        }

    }
    class Program
    {
        static void Main()
        {
            Interger i = new Interger();
            i.n = 1;
        }
    }
}

/*
 * Features of C# Structures:
 * Struct results into value type. Class results into reference type
 * Structures can have methods, fields, indexers, properties, operator methods, and events.
 * Structure can have parameteric and default constructor but is invoked only when created object with new operator.
 * Structures can not have destructor.
 * Unlike classes, structures cannot inherit from another structure or class.
 * Structures cannot be used as a base for other structures or classes.
 * Value types are sealed.
 * A structure can implement one or more interfaces.
 * Structure members cannot be specified as abstract, virtual, or protected.
 * When you create a struct object using the New operator,
 * it gets created and the appropriate constructor is called.
 * Unlike classes, structs can be instantiated without using the New operator.
 * If the New operator is not used, the fields remain unassigned and the object
 * cannot be used until all the fields are initialized.
 */
