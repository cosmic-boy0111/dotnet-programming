using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_programming
{
    internal class Program01
    {
        class Book
        {
            private string Title{ get; set; }
            private string Auther { get; set; }
            private DateTime PublicationDate { get; set; }
            public Book( string title, string auther, DateTime publicationDate ) { 
                this.Title = title;
                this.Auther = auther;
                this.PublicationDate = publicationDate;
            }

            public double getAge()
            {
                DateTime today = DateTime.Today;

                return Math.Ceiling((today - this.PublicationDate).TotalDays / 365.25);
            }

        }
        public static void Main()
        {
            Book mybook = new Book("Mybook", "Gaurav", new DateTime(2015, 12, 1));
            Console.WriteLine($"{mybook.getAge()} years");
        }
    }
}
