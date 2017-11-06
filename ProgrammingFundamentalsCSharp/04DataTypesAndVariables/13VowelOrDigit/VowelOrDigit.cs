using System;

class VowelOrDigit
{
    static void Main()
    {
        char symbol = Convert.ToChar(Console.ReadLine());

        try
        {
            int num = int.Parse(symbol.ToString());
            Console.WriteLine("digit");
        }
        catch (Exception)
        {
            switch (symbol)
            {
                case 'a':
                case 'o':
                case 'u':
                case 'e':
                case 'i':
                case 'y':
                    Console.WriteLine("vowel"); break;

                default:
                    Console.WriteLine("other");
                    break;
            }
        }
    }
}
