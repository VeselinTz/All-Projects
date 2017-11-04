using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.IO;

namespace _05_Book_Library
{
    class Program
    {
        static void Main(string[] args)
        {
            File.Delete("output.txt");
            Library library = new Library();
            var books = new List<Book>();
            books = Book.input();
            library.authorBookSum(books);
        }

    }
    class Library
    {
        public string name { get; set; }
        public List<Book> Books { get; set; }

        public void authorBookSum(List<Book> books)
        {
            Dictionary<string, double> dict = new Dictionary<string, double>();
            for(int i=0;i<books.Count;i++)
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
            dict.OrderByDescending(kp => kp.Value)
              .ThenBy(kp => kp.Key)
              .ToList()
              .ForEach(kp => File.AppendAllText("output.txt",$"{kp.Key} -> {kp.Value:F2}{Environment.NewLine}"));

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

        static public List<Book> input()
        {
            var bookList = new List<Book>();

            string[] INPUT = File.ReadAllLines("input.txt");
            
            for (int i = 1; i <= Convert.ToInt32(INPUT[0]); i++)
            {
                var book = new Book();
                string[] input = INPUT[i].Split();
                book.title = input[0];
                book.author = input[1];
                book.publisher = input[2];
                book.releaseDate = DateTime.ParseExact
                    (input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
                book.ISBN = Convert.ToInt64(input[4]);
                book.price = Convert.ToDouble(input[5]);
                bookList.Add(book);
            }
            return bookList;
        }
    }
}
