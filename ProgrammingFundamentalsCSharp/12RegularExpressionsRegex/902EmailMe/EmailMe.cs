namespace EmailMe
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string email = Console.ReadLine();

            string pattern = @"^(.+)@(.+)$";

            MatchCollection matches = Regex.Matches(email,pattern);

            int leftSum = matches[0].Groups[1].Value.Select(x=>(int)x).Sum();
            int rightSum = matches[0].Groups[2].Value.Select(x => (int)x).Sum();

            if (leftSum-rightSum>=0)
            {
                Console.WriteLine("Call her!");
            }
            else
            {
                Console.WriteLine("She is not the one.");
            }
        }
    }
}
