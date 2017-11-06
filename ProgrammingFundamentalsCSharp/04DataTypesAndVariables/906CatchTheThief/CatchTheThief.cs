using System;

internal class CatchTheThief
{
    private static void Main()
    {
        string numeralType = Console.ReadLine().ToLower();
        int countID = int.Parse(Console.ReadLine());

        long thiefID = long.MinValue;

        for (int i = 1; i <= countID; i++)
        {
            try
            {
                long ID = long.Parse(Console.ReadLine());

                switch (numeralType)
                {
                    case "sbyte":
                        if (ID <= sbyte.MaxValue && ID >= sbyte.MinValue)
                        {
                            thiefID = Math.Max(thiefID, ID);
                        }
                        break;

                    case "int":
                        if (ID <= int.MaxValue && ID >= int.MinValue)
                        {
                            thiefID = Math.Max(thiefID, ID);
                        }
                        break;

                    case "long":
                        thiefID = Math.Max(thiefID, ID);
                        break;
                }
            }
            catch (Exception)
            {
                continue;
            }
        }
        Console.WriteLine(thiefID);
    }
}