using System;

class StringConcetanation
{
    static void Main()
    {
        char delimiter = Convert.ToChar(Console.ReadLine());
        string evenOdd = Console.ReadLine().ToLower();
        int lines = int.Parse(Console.ReadLine());

        string result = "";

        for (int i = 1; i <= lines; i++)
        {
            string text = Console.ReadLine();

            if (evenOdd == "even" && i % 2 == 0)
            {
                result += text + delimiter;
            }
            else if (evenOdd == "odd" && i % 2 == 1)
            {
                result += text + delimiter;
            }
        }

        Console.WriteLine(result.Remove(result.Length - 1));
    }
}
