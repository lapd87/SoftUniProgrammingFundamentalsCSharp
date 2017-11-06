using System;
using System.Collections.Generic;
using System.Linq;

class FixEmails
{
    static void Main()
    {
        Dictionary<string, string> emailbook = new Dictionary<string, string> { };

        string name = Console.ReadLine();

        while (name != "stop")
        {
            string email = Console.ReadLine();

            if (!email.EndsWith(".uk") && !email.EndsWith(".us"))
            {
                if (!emailbook.ContainsKey(name))
                {
                    emailbook.Add(name, email);
                }
                else
                {
                    emailbook[name] = email;
                }
            }

            name = Console.ReadLine();
        }

        foreach (var item in emailbook)
        {
            Console.WriteLine($"{item.Key} -> {item.Value}");
        }
    }
}
