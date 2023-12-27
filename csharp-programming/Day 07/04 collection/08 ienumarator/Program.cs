using System.Collections;


class Program
{
    public class Book
    {
        public string Name { get; set; }
        public double Price { get; set; }
    }

    public class Library : IEnumerable<Book>
    {
        private List<Book> _library = new List<Book>();

        public void AddBook(Book person)
        {
            _library.Add(person);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return _library.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
    public static void Main()
    {
        // Create a list of Book objects
        Library library = new Library();
        library.AddBook(new Book() { Name = "A Fine Balance", Price = 215 });
        library.AddBook(new Book() { Name = "The Guide", Price = 158 });
        library.AddBook(new Book() { Name = "Fasting, Feasting", Price = 258 });

        foreach (Book b in library)
        {
            Console.WriteLine("Book Name: {0}, Book Price: {1}", b.Name, b.Price);
        }

        IEnumerable booksCollection = library;

        foreach (Book b in booksCollection)
        {
            Console.WriteLine("Book Name: {0}, Book Price: {1}", b.Name, b.Price);
        }
    }
}