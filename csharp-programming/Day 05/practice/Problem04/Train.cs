namespace csharp_programming
{

    public class Train : Transport
    {
        private int NumCars { get; set; }
        private int NumPassengers { get; set; }
        public Train(int maxSpeed, int capacity, int numCars, int numPassengers)
            : base(maxSpeed, capacity)
        {
            this.NumCars = numCars;
            this.NumPassengers = numPassengers;
        }
        public override void Move()
        {
            Console.WriteLine("The train is chugging down the tracks.");
        }

        public override void Stop()
        {
            Console.WriteLine("The train has reached its destination.");
        }
    }
}
