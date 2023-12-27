using System.Diagnostics;

namespace csharp_programming{

    public class Stack
    {
        private char[] items;
        private int top;

        public Stack(int size)
        {
            items = new char[size];
            top = -1;
        }

        public void Push(char item)
        {
            if (top == items.Length - 1)
            {
                throw new StackOverflowException();
            }
            items[++top] = item;
        }

        public char Pop()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return items[top--];
        }

        public char Top
        {
            get
            {
                if (top == -1)
                {
                    throw new InvalidOperationException("Stack is empty");
                }
                return items[top];
            }
        }

        public bool IsEmpty => top == -1;

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Stack stack = new Stack(10);
            string s = "Hello";
            foreach (char item in s)
            {
                stack.Push(item);
            }

            s = "";
            while (!stack.IsEmpty)
            {
                s += stack.Pop();
            }

            Debug.Assert(s == "olleH");

        }
    }

}