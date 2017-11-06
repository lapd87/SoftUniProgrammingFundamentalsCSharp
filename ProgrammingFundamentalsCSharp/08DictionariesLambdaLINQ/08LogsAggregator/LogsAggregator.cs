using System;
using System.Collections.Generic;
using System.Linq;

class LogsAggregator
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        SortedDictionary<string, SortedDictionary<string, int>> userIPDuration = new SortedDictionary<string, SortedDictionary<string, int>> { };

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine()
                .Trim()
                .Split(new string[] { " " }, StringSplitOptions
                .RemoveEmptyEntries)
                .ToArray();

            string user = input[1];
            string ip = input[0];
            int duration = int.Parse(input[2]);

            if (!userIPDuration.ContainsKey(user))
            {
                userIPDuration.Add(user, new SortedDictionary<string, int> { });
            }

            if (!userIPDuration[user].ContainsKey(ip))
            {
                userIPDuration[user].Add(ip, 0);
            }

            userIPDuration[user][ip] += duration;
        }

        foreach (var user in userIPDuration)
        {
            string ipAddresses = "";

            foreach (var ip in user.Value)
            {
                ipAddresses += ip.Key + ", ";
            }

            Console.WriteLine($"{user.Key}: {user.Value.Values.Sum()} [{ipAddresses.Substring(0, ipAddresses.Length - 2)}]");
        }
    }
}
