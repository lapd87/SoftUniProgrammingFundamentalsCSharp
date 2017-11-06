namespace LineNumbers
{
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] input = File.ReadAllLines("Input.txt");

            string[] output = input
                                .Select((line, index) => $"{index + 1}. {line}")
                                .ToArray();

            File.WriteAllLines("Output.txt", output);
        }
    }
}