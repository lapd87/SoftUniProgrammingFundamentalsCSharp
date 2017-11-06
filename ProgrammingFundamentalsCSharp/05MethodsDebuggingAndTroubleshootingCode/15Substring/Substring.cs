using System;

class Substring
{
    static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());

        const char Search = 'p';
        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            if (text[i] == Search)
            {
                hasMatch = true;

                int endLength = jump;

                string matchedString;

                if (endLength + i >= text.Length - 1)
                {
                    matchedString = text.Substring(i);
                }
                else
                {
                    matchedString = text.Substring(i, endLength + 1);
                }

                Console.WriteLine(matchedString);

                i += endLength;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
