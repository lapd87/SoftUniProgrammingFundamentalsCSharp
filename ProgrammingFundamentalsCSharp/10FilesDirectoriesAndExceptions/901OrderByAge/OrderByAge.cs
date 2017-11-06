namespace OrderByAge
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            string input = Console.ReadLine();

            List<Person> people = new List<Person> { };

            while (input != "End")
            {
                string[] inputArray = input
                        .Trim()
                        .Split(new string[] { " " }, StringSplitOptions
                        .RemoveEmptyEntries)
                        .ToArray();

                Person currentPerson = new Person();

                currentPerson.Name = inputArray[0];
                currentPerson.ID = inputArray[1];
                currentPerson.Age = int.Parse(inputArray[2]);

                people.Add(currentPerson);

                input = Console.ReadLine();
            }

            foreach (var person in people.OrderBy(p => p.Age))
            {
                Console.WriteLine($"{person.Name} with ID: {person.ID} is {person.Age} years old.");
            }
        }
    }

    internal class Person
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }
    }
}