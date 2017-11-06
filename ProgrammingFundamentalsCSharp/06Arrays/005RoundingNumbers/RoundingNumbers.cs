using System;

class RoundingNumbers
{
    static void Main()
    {
        string[] inputArray = Console.ReadLine().Split(' ');

        double[] newArray = new double[inputArray.Length];
        int[] roundedArray = new int[inputArray.Length];


        for (int i = 0; i < inputArray.Length; i++)
        {
            newArray[i] = double.Parse(inputArray[i]);
            roundedArray[i] = (int)Math.Round(newArray[i], MidpointRounding.AwayFromZero);

            Console.WriteLine($"{newArray[i]} => {roundedArray[i]}");
        }
    }
}
