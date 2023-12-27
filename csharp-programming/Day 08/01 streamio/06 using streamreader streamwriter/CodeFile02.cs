namespace csharp_programming
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                StreamReader sr = new StreamReader("text.txt");
                string line;
                line = sr.ReadLine();
                while (line != null)
                {
                    Console.WriteLine(line);
                    line = sr.ReadLine();
                }
                sr.Close();
            }catch(Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}