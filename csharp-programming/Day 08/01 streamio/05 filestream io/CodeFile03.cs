using System.Text;

namespace csharp_programming
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                FileStream booksFile = new FileStream("book.txt", FileMode.Append, FileAccess.Write);
                Book book = new Book() { 
                    Name = "Rich Dad, Poor Dad",
                    Price = 375
                };

                string s = string.Format("{0, -20} {1, 10:F2}",book.Name, book.Price);
                UTF8Encoding e = new UTF8Encoding();
                byte[] bytes = e.GetBytes(s);
                int byteCount = e.GetByteCount("A") * 31;

                booksFile.Seek(byteCount, SeekOrigin.Begin);
                booksFile.Write(bytes, 0, byteCount);

                booksFile.Close();

            }
            catch (Exception x)
            {
                Console.WriteLine(x);
            }
        }
    }
}