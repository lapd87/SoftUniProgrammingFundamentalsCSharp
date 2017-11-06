namespace EmailStatistics
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> domainUser = new Dictionary<string, List<string>> { };

            for (int i = 0; i < n; i++)
            {
                string email = Console.ReadLine();

                string valid = @"^([a-zA-Z]{5,})@([a-z]{3,}\.(com|bg|org))$";

                if (Regex.IsMatch(email, valid))
                {
                    string user = Regex.Match(email, valid).Groups[1].Value;
                    string domain = Regex.Match(email, valid).Groups[2].Value;

                    if (!domainUser.ContainsKey(domain))
                    {
                        domainUser.Add(domain, new List<string> { });
                    }

                    if (!domainUser[domain].Contains(user))
                    {
                        domainUser[domain].Add(user);
                    }
                }
            }

            foreach (var domain in domainUser.OrderByDescending(x => x.Value.Count()))
            {
                Console.WriteLine($"{domain.Key}:");
                Console.WriteLine($"### {string.Join($"{Environment.NewLine}### ", domain.Value)}");
            }
        }
    }
}