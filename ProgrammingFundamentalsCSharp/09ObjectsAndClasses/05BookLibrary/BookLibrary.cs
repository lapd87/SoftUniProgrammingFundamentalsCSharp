namespace BookLibrary
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Library newLibrary = new Library();
            newLibrary.Books = new List<Book> { };

            for (int i = 0; i < n; i++)
            {
                newLibrary.Books.Add(ReadBook());
            }

            PrintBooks(newLibrary);
        }

        private static void PrintBooks(Library newLibrary)
        {
            var sortAuthorsPrice = newLibrary.Books
                      .GroupBy(book => book.Author)
                      .Select(l => new
                      {
                          Author = l.Key,
                          Price = l.Sum(p => p.Price)
                      })
                      .OrderByDescending(p => p.Price)
                      .ThenBy(a => a.Author)
                      .ToList();

            foreach (var item in sortAuthorsPrice)
            {
                Console.WriteLine($"{item.Author} -> {item.Price:f2}");
            }
        }

        private static Book ReadBook()
        {
            string[] input = Console.ReadLine()
                        .Trim()
                        .Split(new string[] { " " }, StringSplitOptions
                        .RemoveEmptyEntries)
                        .ToArray();

            Book currentBook = new Book();

            currentBook.Title = input[0];
            currentBook.Author = input[1];
            currentBook.Publisher = input[2];
            currentBook.ReleaseDate = DateTime.ParseExact(input[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            currentBook.ISBN = input[4];
            currentBook.Price = decimal.Parse(input[5]);

            return currentBook;
        }
    }

    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
        public DateTime ReleaseDate { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
    }

    internal class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
    }
}