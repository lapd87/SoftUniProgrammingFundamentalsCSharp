namespace FixEmails
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class StartUp
    {
        public static void Main()
        {
            string[] inputFile = File.ReadAllLines("../../input.txt");

            int inputLine = 0;

            List<string> output = new List<string> { };

            while (inputLine < inputFile.Length)
            {
                Dictionary<string, string> emailbook = new Dictionary<string, string> { };

                string name = inputFile[inputLine];

                inputLine++;

                while (name != "stop")
                {
                    string email = inputFile[inputLine];

                    inputLine++;

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

                    name = inputFile[inputLine];

                    inputLine++;
                }

                foreach (var item in emailbook)
                {
                    output.Add($"{item.Key} -> {item.Value}");
                }
            }

            File.WriteAllText("../../output.txt", string.Join($"{Environment.NewLine}", output));
        }
    }
}