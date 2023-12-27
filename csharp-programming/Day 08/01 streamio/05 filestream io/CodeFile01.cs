using System.Text;

namespace csharp_programming
{
    class Program
    {
        public static void Main(string[] args)
        {
            try {

                Book[] books = new Book[]
                {
                    new Book {
                        Name= "A Fine Balance", 
                        Price = 251
                    },
                    new Book {
                        Name= "The Guid", 
                        Price = 158
                    },
                    new Book {
                        Name= "Fasting, Fasting", 
                        Price = 258
                    },
                };

                FileStream bookFile = new FileStream("book.txt", FileMode.Create, FileAccess.Write);

                UTF8Encoding e = new UTF8Encoding();

                foreach (Book book in books)
                {
                    string s = string.Format("{0 , -20} {1, 10:F2}", book.Name, book.Price);
                    byte[] bytes = e.GetBytes(s);
                    bookFile.Write(bytes, 0, bytes.Length);
                }

                bookFile.Close();

            }catch(Exception x) {
                Console.WriteLine(x);
            }
        }
    }
}