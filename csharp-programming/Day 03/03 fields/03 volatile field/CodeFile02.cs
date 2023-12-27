namespace csharp_programming {
    class Integer {
        public readonly volatile int value;
    }
    class Program {
        static void Main() {
            Integer i = new Integer();
        }
    }
}

// a volatile field cannot be read only