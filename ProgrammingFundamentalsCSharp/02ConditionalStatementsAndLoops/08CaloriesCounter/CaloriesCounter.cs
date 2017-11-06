﻿using System;

class CaloriesCounter
{
    static void Main()
    {
        int ingredientsCount = int.Parse(Console.ReadLine());

        int calories = 0;

        for (int i = 0; i < ingredientsCount; i++)
        {
            string ingredient = Console.ReadLine().ToLower();

            switch (ingredient)
            {
                case "cheese":
                    calories += 500;
                    break;
                case "tomato sauce":
                    calories += 150;
                    break;
                case "salami":
                    calories += 600;
                    break;
                case "pepper":
                    calories += 50;
                    break;
            }
        }

        Console.WriteLine("Total calories: " + calories);
    }
}
