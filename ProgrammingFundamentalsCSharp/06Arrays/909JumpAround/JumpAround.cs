using System;
using System.Linq;

class JumpAround
{
    static void Main()
    {
        int[] array = Console.ReadLine()
        .Trim()
        .Split(new string[] { " " }, StringSplitOptions
        .RemoveEmptyEntries)
        .Select(int.Parse)
        .ToArray();

        int sum = 0;
        int index = 0;

        while (true)
        {
            if (index + array[index] < array.Length)
            {
                sum += array[index];
                index += array[index];
            }
            else if (index - array[index] >= 0)
            {
                sum += array[index];
                index -= array[index];
            }
            else
            {
                sum += array[index];
                break;
            }
        }

        Console.WriteLine(sum);
    }
}
