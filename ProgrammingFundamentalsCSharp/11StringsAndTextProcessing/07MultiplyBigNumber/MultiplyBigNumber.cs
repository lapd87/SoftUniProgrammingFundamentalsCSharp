namespace MultiplyBigNumber
{
    using System;

    public class StartUp
    {
        public static void Main()
        {
            string num = Console.ReadLine().TrimStart('0');
            int multiplier = int.Parse(Console.ReadLine());

            if (multiplier==0 || num==string.Empty)
            {
                Console.WriteLine(0);
                return;
            }

            int reminder = 0;
            string result = "";

            for (int i = num.Length - 1; i >= 0; i--)
            {
                int temp = (num[i] - 48) * multiplier + reminder;

                reminder = 0;

                if (temp > 9 && i != 0)
                {
                    while (temp > 9)
                    {
                        temp -= 10;
                        reminder++;
                    }

                    result = temp.ToString() + result;
                }
                else
                {
                    result = temp.ToString() + result;
                }
            }

            Console.WriteLine(result);
        }
    }
}