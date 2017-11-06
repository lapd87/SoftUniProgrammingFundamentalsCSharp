namespace Weather
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            string pattern = @"([A-Z]{2})(\d+.\d+)([a-zA-Z]+)\|";

            Dictionary<string, string> cityTempWeather = new Dictionary<string, string> { };

            while (input != "end")
            {
                foreach (Match m in Regex.Matches(input, pattern))
                {
                    string city = m.Groups[1].Value;
                    string tempWeather = m.Groups[2].Value + "@!" + m.Groups[3].Value;

                    cityTempWeather[city] = tempWeather;
                }

                input = Console.ReadLine();
            }

            foreach (var item in cityTempWeather.OrderBy(x => double.Parse(x
                                        .Value
                                        .Split(new string[] { "@!" }, StringSplitOptions.None)
                                        .ToArray()[0])))
            {
                string[] tempWeather = item
                                    .Value
                                    .Split(new string[] { "@!" }, StringSplitOptions.None)
                                    .ToArray();

                Console.WriteLine($"{item.Key} => {double.Parse(tempWeather[0]):f2} => {tempWeather[1]}");
            }
        }
    }
}
