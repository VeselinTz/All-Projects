using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            Library library = new Library();
            int n = int.Parse(Console.ReadLine());
            var books = new List<Book>();
            for (int i = 0; i < n; i++)
                books.Add(Book.input());
            var date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
            library.authorBookSum(books,date);
        }

    }
    class Library
    {
        public string name { get; set; }
        public List<Book> Books { get; set; }

        public void authorBookSum(List<Book> books, DateTime date)
        {
            books
              .Where(kp => kp.releaseDate >= date)
              .OrderBy(kp => kp.releaseDate)
              .ThenBy(kp => kp.title)
              .ToList()
              .ForEach(kp => Console.WriteLine
              ($"{kp.title} -> " +
              $"{kp.releaseDate.Day.ToString("00")}" +
              $".{kp.releaseDate.Month.ToString("00")}" +
              $".{kp.releaseDate.Year}"));
        }

    }
    class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public DateTime releaseDate { get; set; }
        public long ISBN { get; set; }
        public double price { get; set; }

        static public Book input()
        {
            var book = new Book();
            string[] imput = Console.ReadLine().Split();

            book.title = imput[0];
            book.author = imput[1];
            book.publisher = imput[2];
            book.releaseDate = DateTime.ParseExact
                (imput[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            book.ISBN = Convert.ToInt64(imput[4]);
            book.price = Convert.ToDouble(imput[5]);

            return book;
        }
    }
}
