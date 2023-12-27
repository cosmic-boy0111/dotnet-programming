using System.Text;

namespace csharp_programming
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {

                FileStream bookFile = new FileStream("book.txt", FileMode.Open, FileAccess.Read);

                List<Book> books= new List<Book>();

                UTF8Encoding e = new UTF8Encoding();

                int byteCount = e.GetByteCount("A") * 31;

                byte[] bytes = new byte[byteCount];

                do
                {
                    if (bookFile.Read(bytes, 0, byteCount) == 0)
                        break;
                    string bookData = e.GetString(bytes);
                    Console.WriteLine(bookData);
                    books.Add(new Book
                    {
                        Name = bookData.Substring(0, 20).Trim(),
                        Price = Convert.ToDouble(bookData.Substring(21))
                    });
                }while(true);

                bookFile.Close();
            }
            catch (Exception x)
            {
                Console.WriteLine(x);
            }
        }
    }
}