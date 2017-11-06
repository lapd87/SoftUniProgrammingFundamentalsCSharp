namespace MelrahShake
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (pattern.Length > 0)
            {
                int patternCount = 0;
                int index = text.IndexOf(pattern);

                while (patternCount < 3 && index >= 0)
                {
                    index = text.IndexOf(pattern, index + 1);
                    patternCount++;
                }

                if (patternCount > 1)
                {
                    Console.WriteLine("Shaked it.");

                    text = text.Remove(text.IndexOf(pattern), pattern.Length);
                    text = text.Remove(text.LastIndexOf(pattern), pattern.Length);
                    pattern = pattern.Remove(pattern.Length / 2, 1);
                }
                else
                {
                    break;
                }
            }
            Console.WriteLine("No shake.");
            Console.WriteLine(text);
        }
    }
}