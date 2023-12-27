namespace csharp_programming
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                StreamReader sr = new StreamReader("text.txt");
                int charData;
                charData = sr.Read();
                while (charData != -1)
                {
                    Console.WriteLine(Convert.ToChar(charData));
                    charData = sr.Read();
                    Thread.Sleep(100);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}