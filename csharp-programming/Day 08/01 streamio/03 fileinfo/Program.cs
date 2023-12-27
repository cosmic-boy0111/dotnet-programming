namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string filename = "a.txt";
            FileInfo aInfo = new FileInfo(filename);

            if (aInfo.Exists)
                aInfo.Delete();

            StreamWriter sw = aInfo.AppendText();
            sw.WriteLine("Hi, World");
            sw.WriteLine("Hello, World");
            sw.Close();

            string filename2 = "b.txt";
            FileInfo bInfo = new FileInfo(filename2);

            if(bInfo.Exists)
                bInfo.Delete();

            aInfo.CopyTo(filename2);
        }
    }
}
