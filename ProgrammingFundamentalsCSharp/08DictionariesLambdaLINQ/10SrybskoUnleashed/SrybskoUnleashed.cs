using System;
using System.Collections.Generic;
using System.Linq;

class SrybskoUnleashed
{
    static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<string, Dictionary<string, int>> venueSingerEarnings = new Dictionary<string, Dictionary<string, int>> { };

        while (input != "End")
        {
            try
            {
                string[] inputArray = input
                            .Trim()
                            .Split(new string[] { " @" }, StringSplitOptions
                            .RemoveEmptyEntries)
                            .ToArray();

                string singer = inputArray[0];


                string[] venuePriceTickets = inputArray[1]
                    .Trim()
                    .Split(new string[] { " " }, StringSplitOptions
                    .RemoveEmptyEntries)
                    .Reverse()
                    .ToArray();

                int earnings = int.Parse(venuePriceTickets[0])
                            * int.Parse(venuePriceTickets[1]);

                string venue = String.Join(" ", venuePriceTickets
                                            .Skip(2)
                                            .Reverse()
                                            .ToArray());

                if (!venueSingerEarnings.ContainsKey(venue))
                {
                    venueSingerEarnings.Add(venue, new Dictionary<string, int> { });
                }

                if (!venueSingerEarnings[venue].ContainsKey(singer))
                {
                    venueSingerEarnings[venue].Add(singer, 0);
                }

                venueSingerEarnings[venue][singer] += earnings;

                input = Console.ReadLine();
            }
            catch (Exception)
            {
                input = Console.ReadLine();
            }
        }

        foreach (var venue in venueSingerEarnings)
        {
            Console.WriteLine($"{venue.Key}");

            foreach (var singer in venue.Value
                                     .OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"#  {singer.Key} -> {singer.Value}");
            }
        }
    }
}
