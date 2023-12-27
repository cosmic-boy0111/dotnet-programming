namespace csharp_programming {
    class Integer {
        static int value;
        static Integer() {
            value = 1;
        }
    }
    class Program {
        static void Main() {
            Integer obj = new Integer();
            Integer obj2 = new Integer();
        }
    }
}

/*
 * - Static constructor is invoked only once when any member of the class is accessed.
 */
