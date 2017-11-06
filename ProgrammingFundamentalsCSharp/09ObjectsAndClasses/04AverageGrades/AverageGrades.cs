namespace AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            List<Student> students = new List<Student> { };

            for (int i = 0; i < n; i++)
            {
                Student currnetStudent = ReadStudent();

                if (currnetStudent.AverageGrade() >= 5)
                {
                    students.Add(currnetStudent);
                }
            }

            foreach (var item in students.OrderBy(s => s.Name).ThenByDescending(s => s.AverageGrade()))
            {
                Console.WriteLine($"{item.Name} -> {item.AverageGrade():f2}");
            }
        }

        private static Student ReadStudent()
        {
            string[] input = Console.ReadLine()
                        .Trim()
                        .Split(new string[] { " " }, StringSplitOptions
                        .RemoveEmptyEntries)
                        .ToArray();

            List<double> grades = new List<double> { };

            for (int i = 1; i < input.Length; i++)
            {
                grades.Add(double.Parse(input[i]));
            }

            Student currentStudent = new Student();

            currentStudent.Name = input[0];
            currentStudent.Grades = grades;

            return currentStudent;
        }

        class Student
        {
            public string Name { get; set; }
            public List<double> Grades { get; set; }
            public double AverageGrade()
            {
                return Grades.Sum() / Grades.Count();
            }
        }
    }
}
