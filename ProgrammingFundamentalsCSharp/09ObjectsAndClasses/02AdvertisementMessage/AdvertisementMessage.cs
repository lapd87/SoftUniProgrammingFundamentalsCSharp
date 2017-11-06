namespace AdvertisementMessage
{
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                var advert = Advert(rnd);

                Console.WriteLine(string.Join(" ", advert.GetType().
                                           GetProperties().
                                           Select(a => a.GetValue(advert))));
            }
        }

        private static Message Advert(Random rnd)
        {
            string[] phrases = { "Excellent product.",
                                 "Such a great product.",
                                 "I always use that product.",
                                 "Best product of its category.",
                                 "Exceptional product.",
                                 "I can’t live without this product." };

            string[] events = { "Now I feel good.",
                                "I have succeeded with this product.",
                                "Makes miracles. I am happy of the results!",
                                "I cannot believe but now I feel awesome.",
                                "Try it yourself, I am very satisfied.",
                                "I feel great!" };

            string[] authors = { "Diana",
                                 "Petya",
                                 "Stella",
                                 "Elena",
                                 "Katya",
                                 "Iva",
                                 "Annie",
                                 "Eva" };

            string[] cities = { "Burgas",
                                "Sofia",
                                "Plovdiv",
                                "Varna",
                                "Ruse" };

            Message advert = new Message();

            advert.Phrase = phrases[rnd.Next(0, phrases.Length)];
            advert.Event = events[rnd.Next(0, events.Length)];
            advert.Author = authors[rnd.Next(0, authors.Length)];
            advert.City = cities[rnd.Next(0, cities.Length)];

            return advert;
        }
    }

    internal class Message
    {
        public string Phrase { get; set; }
        public string Event { get; set; }
        public string Author { get; set; }
        public string AuthorCityJoin { get { return "-"; } }
        public string City { get; set; }
    }
}