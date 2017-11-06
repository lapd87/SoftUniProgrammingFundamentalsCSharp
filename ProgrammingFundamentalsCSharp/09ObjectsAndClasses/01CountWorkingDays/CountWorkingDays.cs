namespace CountWorkingDays
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    public class StartUp
    {
        public static void Main()
        {
            DateTime startDate = DateTime.ParseExact(Console.ReadLine(),
                                    "dd-MM-yyyy",
                                    CultureInfo.InvariantCulture);

            DateTime endDate = DateTime.ParseExact(Console.ReadLine(),
                                    "dd-MM-yyyy",
                                    CultureInfo.InvariantCulture);

            string[] holidays = { "01-01-1004",
                                  "03-03-1004",
                                  "01-05-1004",
                                  "06-05-1004",
                                  "24-05-1004",
                                  "06-09-1004",
                                  "22-09-1004",
                                  "01-11-1004",
                                  "24-12-1004",
                                  "25-12-1004",
                                  "26-12-1004" };

            List<DateTime> holidaysDates = new List<DateTime> { };

            foreach (var item in holidays)
            {
                holidaysDates.Add(DateTime.ParseExact(item,
                                        "dd-MM-yyyy",
                                        CultureInfo.InvariantCulture));
            }

            int workingDays = 0;

            for (DateTime i = startDate; i <= endDate; i = i.AddDays(1))
            {
                string checkHoliday = i.Day + "-" + i.Month + "-1004";

                DateTime checkHolidayDate = DateTime.ParseExact(checkHoliday,
                                          "d-M-yyyy",
                                          CultureInfo.InvariantCulture);

                if (i.DayOfWeek != DayOfWeek.Saturday
                    && i.DayOfWeek != DayOfWeek.Sunday
                    && !holidaysDates.Contains(checkHolidayDate))
                {
                    workingDays++;
                }
            }

            Console.WriteLine(workingDays);
        }
    }
}
