namespace OddLines
{
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines("Input.txt");

            string[] output = input
                                .Where((line, index) => index % 2 == 1)
                                .ToArray();

            File.WriteAllLines("Output.txt", output);
        }
    }
}