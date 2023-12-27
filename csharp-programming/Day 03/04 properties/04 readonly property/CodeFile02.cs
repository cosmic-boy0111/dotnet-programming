namespace csharp_programming {
    class Math {
        public static double PI { get; private set; }
    
        public Math() {
            PI = 3.1428;
        }
    }

    class Program {
        static void Main() {
            double pi = Math.PI;
        }
    }
}

/*
 * Public property with private mutator.
 */