namespace csharp_programming
{
    public class AndroidPhone : Phone
    {
        private string AndroidVersion { get; set; }
        private int NumCameras { get; set; }

        public AndroidPhone(
            string brand,
            string model,
            double screenSize,
            string androidVersion,
            int numCameras
            )
            : base(brand, model, screenSize)
        {
            this.NumCameras = numCameras;
            this.AndroidVersion = androidVersion;
        }

        public override void Call()
        {
            Console.WriteLine("Calling from an Android phone");
        }

        public override void Text()
        {
            Console.WriteLine("Sending a text message from an Android phone.");
        }
    }
}
