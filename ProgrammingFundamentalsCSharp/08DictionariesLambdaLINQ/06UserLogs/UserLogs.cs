using System;
using System.Collections.Generic;
using System.Linq;

class UserLogs
{
    static void Main()
    {
        string[] input = Console.ReadLine()
            .Trim()
            .Split(new string[] { " ", "=" }, StringSplitOptions
            .RemoveEmptyEntries)
            .ToArray();

        SortedDictionary<string, Dictionary<string, int>> userIPMessage = new SortedDictionary<string, Dictionary<string, int>> { };

        while (input[0] != "end")
        {
            string user = input[5];
            string ip = input[1];

            if (!userIPMessage.ContainsKey(user))
            {
                userIPMessage.Add(user, new Dictionary<string, int> { });
            }

            if (!userIPMessage[user].ContainsKey(ip))
            {
                userIPMessage[user].Add(ip, 1);
            }
            else
            {
                userIPMessage[user][ip] += 1;
            }

            input = Console.ReadLine()
                    .Trim()
                    .Split(new string[] { " ", "=" }, StringSplitOptions
                    .RemoveEmptyEntries)
                    .ToArray();
        }

        foreach (var user in userIPMessage)
        {
            string resultIPCount = "";

            foreach (var ip in user.Value)
            {
                resultIPCount += ip.Key + " => " + ip.Value + ", ";
            }

            Console.WriteLine(user.Key + ": ");
            Console.WriteLine(resultIPCount
                        .Substring(0, resultIPCount.Length - 2) + ".");
        }
    }
}
