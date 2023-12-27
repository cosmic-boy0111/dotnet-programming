namespace csharp_programming {
    class Math {
        public int Sum(params int[] n) { // with int you can 
            // write object to accept any type of element
            int result = 0;
            foreach(int t in n)
                result += t;
            return result;
        }
    }
    class Program {
        static void Main() {
            Math m = new Math();
            int n = m.Sum(1, 5);
            n = m.Sum(1, 5, 7);
        }
    }
}