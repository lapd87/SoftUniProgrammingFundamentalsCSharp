using System;

class IndexOfLetters
{
    static void Main()
    {
        char[] inputArray = Console.ReadLine().ToCharArray();

        for (int i = 0; i < inputArray.Length; i++)
        {
            Console.WriteLine(inputArray[i] + " -> "
                                + (int)(inputArray[i] - 97));
        }
    }
}
