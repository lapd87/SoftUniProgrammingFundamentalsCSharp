using System;

internal class GraterOfTwoValues
{
    private static void Main()
    {
        string dataType = Console.ReadLine(); //doesn't need it

        string input1 = Console.ReadLine();
        string input2 = Console.ReadLine();

        string max = GetMax(input1, input2);

        Console.WriteLine(max);
    }

    private static string GetMax(string input1, string input2)
    {
        try
        {
            double num1 = double.Parse(input1);
            double num2 = double.Parse(input2);

            return Math.Max(num1, num2).ToString();
        }
        catch (Exception)
        {
            if (string.CompareOrdinal(input1, input2) >= 0)
            {
                return input1;
            }
            else
            {
                return input2;
            }
        }
    }
}