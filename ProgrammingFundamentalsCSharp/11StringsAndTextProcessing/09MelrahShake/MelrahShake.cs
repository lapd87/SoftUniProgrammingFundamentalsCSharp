namespace MelrahShake
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string text = Console.ReadLine();
            string pattern = Console.ReadLine();

            while (true)
            {
                int firstIndex = -1;
                int lastIndex = -1;

                int tempIndex = -1;

                for (int i = 0; i <= text.Length - pattern.Length; i++)
                {
                    int count = 0;

                    for (int j = 0; j < pattern.Length; j++)
                    {
                        if (text[i + j] == pattern[j])
                        {
                            count++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (count == pattern.Length)
                    {
                        tempIndex = i;
                    }

                    if (firstIndex == -1 && tempIndex != -1)
                    {
                        firstIndex = tempIndex;
                    }

                    if (tempIndex != firstIndex)
                    {
                        lastIndex = tempIndex;
                    }
                }

                if (firstIndex == -1 || lastIndex == -1)
                {
                    Console.WriteLine("No shake.");
                    break;
                }

                Console.WriteLine("Shaked it.");

                List<char> textList = text.ToCharArray().ToList();
                textList.RemoveRange(lastIndex, pattern.Length);
                textList.RemoveRange(firstIndex, pattern.Length);
                text = string.Join("", textList);

                List<char> patternList = pattern.ToCharArray().ToList();
                patternList.RemoveAt(patternList.Count / 2);
                pattern = string.Join("", patternList);

                if (pattern.Length == 0)
                {
                    Console.WriteLine("No shake.");
                    break;
                }
            }

            Console.WriteLine(string.Join("", text));
        }
    }
}