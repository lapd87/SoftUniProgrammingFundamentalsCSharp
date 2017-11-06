namespace BookLibraryModification
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] inputFile = File.ReadAllLines("../../input.txt");

            int inputLine = 0;

            List<string> output = new List<string> { };

            while (inputLine < inputFile.Length)
            {
                int n = int.Parse(inputFile[inputLine]);

                inputLine++;

                Library newLibrary = new Library();
                newLibrary.Books = new List<Book> { };

                for (int i = 0; i < n; i++)
                {
                    newLibrary.Books.Add(ReadBook(inputFile, inputLine));

                    inputLine++;
                }

                DateTime afterDate = DateTime.ParseExact(inputFile[inputLine], "dd.MM.yyyy", CultureInfo.InvariantCulture);

                inputLine++;

                output.Add(PrintBooks(newLibrary, afterDate));
            }

            File.WriteAllText("../../output.txt", string.Join($"{Environment.NewLine}", output));
        }

        private static string PrintBooks(Library newLibrary, DateTime afterDate)
        {
            var sortTitleDates = newLibrary.Books
                                        .OrderBy(d => d.ReleaseDate)
                                        .ThenBy(t => t.Title)
                                        .ToList();

            string result = "";

            foreach (var item in sortTitleDates)
            {
                if (item.ReleaseDate > afterDate)
                {
                    result += $"{item.Title} -> {item.ReleaseDate.ToString("dd.MM.yyyy")}{Environment.NewLine}";
                }
            }

            return result;
        }

        private static Book ReadBook(string[] inputFile, int inputLine)
        {
            string[] input = inputFile[inputLine]
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