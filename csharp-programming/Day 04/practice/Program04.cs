namespace csharp_programming
{
    internal class Program04
    {
        public class CircularBuffer
        {
            private int[] buffer;
            private static int start = -1;
            private static int end = -1;
            public CircularBuffer(int size)
            {
                buffer = new int[size];
            }

            public void Enqueue(int value)
            {
                if ((start == 0 || end == buffer.Length - 1) || start == end + 1)
                    throw new Exception("Buffer is full");
                if (end + 1 == buffer.Length && start != 0) end = -1;
                end++;
                buffer[end] = value;
                if (start == -1) start = 0;
            }

            public int Dequeue()
            {
                if (start == -1 && end == -1)
                    throw new Exception("Buffer is empty");
                int ans = buffer[start];
                start++;
                if (start == buffer.Length) start = 0;
                if (start - 1 == end)
                {
                    start = -1;
                    end = -1;
                }
                return ans;
            }
        }
        public static void Main()
        {
            CircularBuffer c = new CircularBuffer(10);
            c.Enqueue(1);
            int result = c.Dequeue();
        }
    }
}
