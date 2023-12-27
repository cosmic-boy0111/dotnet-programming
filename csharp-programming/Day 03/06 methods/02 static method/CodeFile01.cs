namespace csharp_programming {
    class Math {
        public static int Sum(params int[] n) {
            int result = 0;
            foreach(int t in n)
                result += t;
            return result;
        }
        public int add()
        {
            return 0;
        }
    }
    class Program {
        static void Main() {
            int n = Math.Sum(1, 5);
            n = Math.Sum(1, 5, 7);
        }
    }
}

// in c# static methods (class method) can be called using class only.
// it cannot be called using instance of a class

// Non-static method (also known as instance method) can be called using instance only.  
// it cannot be called using class.