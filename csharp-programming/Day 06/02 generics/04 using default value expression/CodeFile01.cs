namespace csharp_programming
{
    public class Example<T>
    {
        private T value;
        public Example(T value = default) { 
            this.value = value;
        }

        public void PrintValue()
        {
            Console.WriteLine($"Value is : {value}");
        }

    }

    class Point
    {
        int x;
        int y;
        public Point(int x, int y)
        {
            this.y = y;
            this.x = x;

        }
    }
    class Program
    {
        public static void Main(string[] args)
        {
            Example<int> example1 = new Example<int>();
            example1.PrintValue();

            Point p = new Point(1, 2);
            Example<Point> example2 = new Example<Point>(p);
            example2.PrintValue();



        }
    }

}

/*
 * default value we have to assign to make compiler to assign 
 * appropriate value to given generic