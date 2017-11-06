using System;
using System.Collections.Generic;
using System.Linq;

class HandsOfCards
{
    static void Main()
    {
        Dictionary<string, Dictionary<string, int>> peopleCardsScore = new Dictionary<string, Dictionary<string, int>> { };

        string[] peopleCards = Console.ReadLine()
                        .Split(new string[] { ":" }, StringSplitOptions
                        .None)
                        .ToArray();

        while (peopleCards[0] != "JOKER")
        {
            string person = peopleCards[0];

            if (!peopleCardsScore.ContainsKey(person))
            {
                peopleCardsScore.Add(person, new Dictionary<string, int> { });
            }

            string[] cards = peopleCards[1]
                        .Trim()
                        .Split(new string[] { ", " }, StringSplitOptions
                        .RemoveEmptyEntries)
                        .ToArray();

            foreach (var item in cards)
            {
                char[] cardType = item.ToCharArray();

                int cardValue = 0;

                switch (cardType.Last())
                {
                    case 'S': cardValue = 4; break;
                    case 'H': cardValue = 3; break;
                    case 'D': cardValue = 2; break;
                    case 'C': cardValue = 1; break;
                }

                switch (cardType[0])
                {
                    case '2':
                    case '3':
                    case '4':
                    case '5':
                    case '6':
                    case '7':
                    case '8':
                    case '9':
                        cardValue *= int.Parse(cardType[0].ToString());
                        break;
                    case '1': cardValue *= 10; break;
                    case 'J': cardValue *= 11; break;
                    case 'Q': cardValue *= 12; break;
                    case 'K': cardValue *= 13; break;
                    case 'A': cardValue *= 14; break;
                }

                if (!peopleCardsScore[person].ContainsKey(item))
                {
                    peopleCardsScore[person].Add(item, cardValue);
                }
            }

            peopleCards = Console.ReadLine()
                         .Split(new string[] { ":" }, StringSplitOptions
                         .None)
                         .ToArray();
        }

        foreach (var person in peopleCardsScore)
        {
            int sum = 0;

            foreach (var card in person.Value)
            {
                sum += card.Value;
            }

            Console.WriteLine($"{person.Key}: {sum}");
        }
    }
}
