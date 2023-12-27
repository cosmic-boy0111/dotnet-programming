namespace csharp_programming
{
    public class Car : Transport
    {
        private string Model { get; set; }
        private int NumWheels { get; set; }

        public Car(int maxSpeed, int capacity, string model, int numWheels)
            : base(maxSpeed, capacity)
        {
            this.Model = model;
            this.NumWheels = numWheels;
        }
        public override void Move()
        {
            Console.WriteLine("The car is cruising down the highway");
        }

        public override void Stop()
        {
            Console.WriteLine("The car has come to a stop.");
        }
    }
}
