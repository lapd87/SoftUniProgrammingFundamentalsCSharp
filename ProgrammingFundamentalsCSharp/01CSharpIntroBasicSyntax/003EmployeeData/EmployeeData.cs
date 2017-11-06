using System;

class EmployeeData
{
    static void Main()
    {
        string name = Console.ReadLine();
        int age = int.Parse(Console.ReadLine());
        int id = int.Parse(Console.ReadLine());
        decimal salary = decimal.Parse(Console.ReadLine());

        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Age: {age}");
        Console.WriteLine($"Employee ID: {id:#00000000}");
        Console.WriteLine($"Salary: {salary:f2}");
    }
}
