namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string filename = "a.txt";

            if(File.Exists(filename))
                File.Delete(filename);

            File.WriteAllText(filename, "Hello, World");
            File.AppendAllText(filename, "\n");
            File.AppendAllText(filename, "Hi, World");

            string filename2 = "b.txt";

            if(File.Exists(filename2))
                File.Delete(filename2);

            File.Copy(filename, filename2);

        }
    }
}
