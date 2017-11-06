using System;

class BalancedBrackets
{
    static void Main()
    {
        byte n = byte.Parse(Console.ReadLine());

        string openBracket = "";
        string closeBracket = "";
        byte count = 0;

        for (int i = 1; i <= n; i++)
        {
            string text = Console.ReadLine();

            if (text != "(" && text != ")")
            {
                continue;
            }

            if (text == "(" && openBracket == "")
            {
                openBracket = text;
                closeBracket = "";
                count++;
            }
            else if (text == ")" && openBracket == "(")
            {
                closeBracket = text;
                openBracket = "";
                count++;
            }
            else
            {
                Console.WriteLine("UNBALANCED");
                return;
            }
        }

        if (closeBracket != ")" && count != 0)
        {
            Console.WriteLine("UNBALANCED");
        }
        else
        {
            Console.WriteLine("BALANCED");
        }
    }
}
