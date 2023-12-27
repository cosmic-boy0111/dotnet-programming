namespace csharp_programming
{
    internal class Problem
    {
        public static void Main()
        {
            Car c = new Car(400, 2, "Bugati", 4);
            c.Move();
            c.Stop();

            Train t = new Train(100, 100, 12 , 144);
            t.Move();
            t.Stop();
        }
    }
}
