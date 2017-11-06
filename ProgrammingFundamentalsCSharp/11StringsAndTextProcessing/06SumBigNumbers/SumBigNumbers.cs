namespace SumBigNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string firstNum = Console.ReadLine().TrimStart('0');
            string secondNum = Console.ReadLine().TrimStart('0');

            int lengthDiff = Math.Abs(firstNum.Length - secondNum.Length);

            if (firstNum.Length < secondNum.Length)
            {
                firstNum = new string('0', lengthDiff) + firstNum;
            }
            else if (firstNum.Length > secondNum.Length)
            {
                secondNum = new string('0', lengthDiff) + secondNum;
            }

            int reminder = 0;
            string result = "";

            for (int i = firstNum.Length - 1; i >= 0; i--)
            {
                int temp = firstNum[i] - 48 + secondNum[i] - 48 + reminder;

                reminder = 0;

                if (temp > 9 && i != 0)
                {
                    temp -= 10;
                    reminder++;

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
