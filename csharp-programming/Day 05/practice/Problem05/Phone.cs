namespace csharp_programming
{
    public abstract class Phone
    {
        private string Brand { get; set; }
        private string Model { get; set; }
        private double ScreenSize { get; set; }

        public Phone(string brand, string model, double screenSize)
        {
            this.Brand = brand;
            this.Model = model;
            this.ScreenSize = screenSize;
        }

        public abstract void Call();
        public abstract void Text();
    }
}
