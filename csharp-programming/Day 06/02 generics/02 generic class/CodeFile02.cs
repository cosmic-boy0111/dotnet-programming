using System.Diagnostics;
using System.Runtime.ExceptionServices;

namespace csharp_programming{

    public class Stack<T>
    {
        private T[] items;
        private int top;

        public Stack(int size)
        {
            items = new T[size];
            top = -1;
        }

        public void Push(T item)
        {
            if (top == items.Length - 1)
            {
                throw new StackOverflowException();
            }
            items[++top] = item;
        }

        public T Pop()
        {
            if (top == -1)
            {
                throw new InvalidOperationException("Stack is empty");
            }
            return items[top--];
        }

        public T Top
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

    class Pair<T1, T2>
    {
        T1 x;
        T2 y;
        Pair(T1 x, T2 y)
        {
            this.x = x;
            this.y = y;
        }

        public T1 first => this.x;
        public T2 second => this.y;

        public static Pair<T1,T2> make_pair(T1 x,T2 y)
        {
            return new Pair<T1, T2>(x,y);
        }

    }

    class Program
    {
        public static void Main(string[] args)
        {
            Stack<char> stack = new Stack<char>(10);
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

            Debug.Assert(s == "Hello");

            Stack<Pair<int,int>> s_pint = new Stack<Pair<int,int>>(10);

        }
    }

}