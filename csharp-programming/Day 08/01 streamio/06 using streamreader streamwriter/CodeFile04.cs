namespace csharp_programming
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                StreamReader sr = new StreamReader("text.txt");
                string s = sr.ReadToEnd();
                Console.WriteLine(s);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}