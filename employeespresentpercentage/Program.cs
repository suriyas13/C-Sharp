using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Employee> employees = new List<Employee>()
        {
            new Employee("Suriya", 85),
            new Employee("Tushar", 75),
            new Employee("Chadraj", 90),
            new Employee("Kathir", 82)
        };

        int count = CountEmployee(employees, 80);
        Console.WriteLine("Number of employees with present percentage greater than 80%: " + count);
    }

    static int CountEmployee(List<Employee> employees, int threshold)
    {
        int count = 0;
        foreach (var employee in employees)
        {
            if (employee.PresentPercentage > threshold)
            {
                count++;
            }
        }
        return count;
    }
}

class Employee
{
    public string Name { get; set; }
    public int PresentPercentage { get; set; }

    public Employee(string name, int presentPercentage)
    {
        Name = name;
        PresentPercentage = presentPercentage;
    }
}
