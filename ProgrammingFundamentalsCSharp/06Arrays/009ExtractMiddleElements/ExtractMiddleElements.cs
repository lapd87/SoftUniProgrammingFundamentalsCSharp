using System;

class ExtractMiddleElements
{
    static void Main()
    {
        string[] inputArray = Console.ReadLine().Split(' ');

        if (inputArray.Length % 2 == 0)
        {
            string first = inputArray[inputArray.Length / 2 - 1];
            string second = inputArray[inputArray.Length / 2];

            Console.WriteLine("{ " + first + ", " + second + " }");
        }
        else
        {
            if (inputArray.Length == 1)
            {
                Console.WriteLine("{ " + inputArray[0] + " }");
            }
            else
            {
                string first = inputArray[inputArray.Length / 2 - 1];
                string second = inputArray[inputArray.Length / 2];
                string third = inputArray[inputArray.Length / 2 + 1];

                Console.WriteLine("{ " + first + ", " + second + ", " +
                                         third + " }");
            }
        }
    }
}
