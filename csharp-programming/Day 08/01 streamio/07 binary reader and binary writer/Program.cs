namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            WriteErrorLogToBinaryFile();
            ReadErrorLogFromBinaryFile();
        }

        public static void WriteErrorLogToBinaryFile()
        {
            using ( BinaryWriter writer = new BinaryWriter(File.Open("errorlog.bin",FileMode.Create)))
            {
                writer.Write(0x80000003);
                writer.Write("one or more arguments are invalid");
            }

        }
        public static void ReadErrorLogFromBinaryFile()
        {
            using (BinaryReader reader = new BinaryReader(File.Open("errorlog.bin", FileMode.Open)))
            {
                Console.WriteLine("Error code : " + string.Format("0x{0:x}", reader.ReadInt32()));
                Console.WriteLine("Message : " + reader.ReadString());

            }
        }
    }
}
