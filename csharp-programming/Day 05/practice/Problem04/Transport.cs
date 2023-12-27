namespace csharp_programming
{
    public abstract class Transport
    {
        private int MaxSpeed { get; set; }
        private int Capacity { get; set; }

        public Transport(int maxSpeed, int capacity)
        {
            this.MaxSpeed = maxSpeed;
            this.Capacity = capacity;
        }

        public abstract void Move();
        public abstract void Stop();

    }
}
