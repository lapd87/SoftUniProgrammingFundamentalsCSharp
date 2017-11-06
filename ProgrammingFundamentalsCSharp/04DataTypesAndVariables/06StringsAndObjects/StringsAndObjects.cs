using System;

class StringsAndObjects
{
    static void Main()
    {
        string firstWord = Console.ReadLine();
        string secondWord = Console.ReadLine();

        object sentence = firstWord + " " + secondWord;

        string sentence2 = (string)sentence;

        Console.WriteLine(sentence2);
    }
}
