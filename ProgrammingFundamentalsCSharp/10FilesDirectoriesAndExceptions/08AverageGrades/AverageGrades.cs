namespace AverageGrades
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string[] inputFile = File.ReadAllLines("../../input.txt");

            int inputLine = 0;

            List<string> output = new List<string> { };

            while (inputLine < inputFile.Length)
            {
                int n = int.Parse(inputFile[inputLine]);

                inputLine++;

                List<Student> students = new List<Student> { };

                for (int i = 0; i < n; i++)
                {
                    Student currnetStudent = ReadStudent(inputFile, inputLine);

                    inputLine++;

                    if (currnetStudent.AverageGrade() >= 5)
                    {
                        students.Add(currnetStudent);
                    }
                }

                foreach (var item in students.OrderBy(s => s.Name).ThenByDescending(s => s.AverageGrade()))
                {
                    output.Add($"{item.Name} -> {item.AverageGrade():f2}");
                }
            }

            File.WriteAllText("../../output.txt", string.Join($"{Environment.NewLine}", output));
        }

        private static Student ReadStudent(string[] inputFile, int inputLine)
        {
            string[] input = inputFile[inputLine]
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
    }

    public class Student
    {
        public string Name { get; set; }
        public List<double> Grades { get; set; }
        public double AverageGrade()
        {
            return Grades.Sum() / Grades.Count();
        }
    }
}