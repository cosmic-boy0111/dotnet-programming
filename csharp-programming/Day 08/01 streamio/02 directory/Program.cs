
namespace csharp_programming
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string directory = "temp";
            if(Directory.Exists(directory))
                Directory.Delete(directory, true);

            Directory.CreateDirectory(directory);

            File.Move("b.txt", directory + @"\" + "b.txt");
        }
    }
}
