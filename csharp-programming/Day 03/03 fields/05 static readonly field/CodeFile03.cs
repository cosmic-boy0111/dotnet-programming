﻿namespace csharp_programming {
    class Integer {
        public static int value;

        static Integer() {
            value = 10;
        }
    }
    class Program {
        static void Main() {
             int n = Integer.value;
        }
    }
}