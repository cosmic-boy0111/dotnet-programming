namespace csharp_programming {
    class Integer {
        public int value;
    }

    class Program {
        static void F(out Integer a) {
            a.value = 5;
        }

        static void G(out Integer a) {
            a = new Integer() { value = 10 };
        }

        static void Main() {
            Integer a = new Integer() { value = 1 };
            F(out a);
            G(out a);
        }
    }
}
