using System;
using System.Linq;

class SafeManipulation
{
    static void Main()
    {
        string[] inputArray = Console.ReadLine()
               .Trim()
               .Split(new string[] { " " }, StringSplitOptions
               .RemoveEmptyEntries)
               .ToArray();

        string[] tempArray = inputArray.Clone() as string[];

        string[] command = Console.ReadLine().Trim().Split();

        while (command[0] != "END")
        {
            switch (command[0])
            {
                case "Reverse":
                    Array.Reverse(tempArray);
                    break;

                case "Distinct":
                    tempArray = tempArray.Distinct().ToArray();
                    break;

                case "Replace":
                    int index = int.Parse(command[1].ToString());

                    if (index < 0 || index >= tempArray.Length)
                    {
                        Console.WriteLine("Invalid input!");
                        break;
                    }
                    else
                    {
                        tempArray[index] = command[2].ToString();
                        break;
                    }
                default:
                    Console.WriteLine("Invalid input!");
                    break;

                    Console.WriteLine(string.Join(", ", tempArray));

            }

            command = Console.ReadLine().Trim().Split();
        }

        Console.WriteLine(string.Join(", ", tempArray));
    }
}