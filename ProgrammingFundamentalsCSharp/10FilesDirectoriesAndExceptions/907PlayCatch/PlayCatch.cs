namespace PlayCatch
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            List<string> input = Console.ReadLine()
                                .Split()
                                .ToList();

            int exceptionCount = 0;

            while (exceptionCount < 3)
            {
                try
                {
                    string[] commandArray = Console.ReadLine()
                                            .Split()
                                            .ToArray();

                    switch (commandArray[0])
                    {
                        case "Replace":
                            int index = int.Parse(commandArray[1]);
                            string element = commandArray[2];

                            input.RemoveAt(index);
                            input.Insert(index, element);
                            break;

                        case "Print":
                            int startIndex = int.Parse(commandArray[1]);
                            int endIndex = int.Parse(commandArray[2]);

                            Console.WriteLine(string.Join(", ", input.GetRange(startIndex, endIndex - startIndex + 1)));
                            break;

                        case "Show":
                            int indexPrint = int.Parse(commandArray[1]);

                            Console.WriteLine(input[indexPrint]);
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    exceptionCount++;
                }
                catch (ArgumentException)
                {
                    Console.WriteLine("The index does not exist!");
                    exceptionCount++;
                }
            }

            Console.WriteLine(string.Join(", ", input));
        }
    }
}