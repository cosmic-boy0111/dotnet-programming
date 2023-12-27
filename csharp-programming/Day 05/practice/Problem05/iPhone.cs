namespace csharp_programming
{
    public class iPhone : Phone
    {
        private string IOSVersion { get; set; }
        private bool FingerprintScanner { get; set; }
        public iPhone(
           string brand,
           string model,
           double screenSize,
           string iOSVersion,
           bool fingerprintScanner
           )
           : base(brand, model, screenSize)
        {
            this.FingerprintScanner = fingerprintScanner;
            this.IOSVersion = iOSVersion;
        }
        public override void Call()
        {
            Console.WriteLine("Calling from an iPhone.");
        }

        public override void Text()
        {
            Console.WriteLine("Sending a text message from an iPhone.");
        }
    }
}
