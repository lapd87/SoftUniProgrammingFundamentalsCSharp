namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            List<Town> towns = new List<Town> { };

            while (input != "End")
            {
                Town currentTown = new Town();

                if (input.Contains("=>"))
                {
                    currentTown = ReadTown(input);
                    currentTown.Students = new List<Student> { };
                    towns.Add(currentTown);
                }
                else
                {
                    currentTown = towns.Last();
                    currentTown.Students.Add(ReadStudent(input));
                }

                input = Console.ReadLine();
            }

            List<Group> groups = CreateGroups(towns);

            PrintStudyGroups(groups, towns);

        }

        private static void PrintStudyGroups(List<Group> groups, List<Town> towns)
        {
            Console.WriteLine($"Created {groups.Count} groups in {towns.Count} towns:");

            foreach (var group in groups)
            {
                List<string> emails = new List<string> { };

                foreach (var email in group.Students)
                {
                    emails.Add(email.Email);
                }

                Console.WriteLine($"{group.Town} => {string.Join(", ", emails)}");
            }

        }

        private static List<Group> CreateGroups(List<Town> towns)
        {
            List<Group> groups = new List<Group> { };

            foreach (var town in towns.OrderBy(t => t.Name))
            {
                int groupCount = (int)Math.Ceiling(town.Students.Count * 1.0 / town.LabSeats);

                List<Student> tempList = town.Students
                                                    .OrderBy(s => s.RegistrationDate)
                                                    .ThenBy(s => s.Name)
                                                    .ThenBy(s => s.Email)
                                                    .ToList();

                for (int i = 0; i < groupCount; i++)
                {
                    Group currentGroup = new Group();

                    currentGroup.Town = town.Name;
                    currentGroup.Students = new List<Student> { };

                    foreach (var student in tempList)
                    {
                        if (currentGroup.Students.Count < town.LabSeats)
                        {
                            currentGroup.Students.Add(student);
                        }
                        else
                        {
                            tempList.RemoveRange(0, town.LabSeats);
                            break;
                        }
                    }

                    groups.Add(currentGroup);
                }
            }

            return groups;
        }

        private static Student ReadStudent(string input)
        {
            string[] studentInfo = input
                        .Trim()
                        .Split(new string[] { "|" }, StringSplitOptions
                        .RemoveEmptyEntries)
                        .ToArray();

            Student studentRead = new Student();

            studentRead.Name = studentInfo[0].Trim();
            studentRead.Email = studentInfo[1].Trim();
            studentRead.RegistrationDate = DateTime.ParseExact(studentInfo[2].Trim(), "d-MMM-yyyy", CultureInfo.InvariantCulture);

            return studentRead;
        }

        private static Town ReadTown(string input)
        {

            string[] townSeats = input
                            .Trim()
                            .Split(new string[] { "=>" }, StringSplitOptions
                            .RemoveEmptyEntries)
                            .ToArray();


            string[] seats = townSeats[1]
                            .Trim()
                            .Split(new string[] { " " }, StringSplitOptions
                            .RemoveEmptyEntries)
                            .ToArray();

            Town townRead = new Town();

            townRead.Name = townSeats[0].Trim();
            townRead.LabSeats = int.Parse(seats[0]);

            return townRead;
        }
    }

    class Town
    {
        public string Name { get; set; }
        public int LabSeats { get; set; }
        public List<Student> Students { get; set; }
    }

    class Student
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public DateTime RegistrationDate { get; set; }
    }

    class Group
    {
        public string Town { get; set; }
        public List<Student> Students { get; set; }
    }
}
