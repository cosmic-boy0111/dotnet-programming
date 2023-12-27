namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string filename = "b.txt";
            FileInfo bInfo = new FileInfo(filename);

            string directory = "temp";
            DirectoryInfo directoryInfo = new DirectoryInfo(directory);

            if(directoryInfo.Exists)
                directoryInfo.Delete(true);

            bInfo.MoveTo(directoryInfo.ToString() + @"\" + bInfo.ToString());
        }
    }
}
