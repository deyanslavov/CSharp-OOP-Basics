namespace _01.Define_a_Class_Person
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StartUp
    {
        static void Main()
        {
            var employees = new Dictionary<string, List<Employee>>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                var name = input[0];
                decimal salary = decimal.Parse(input[1]);
                var position = input[2];
                var department = input[3];
                if (!employees.ContainsKey(department))
                {
                    employees.Add(department, new List<Employee>());
                }

                var employee = new Employee
                {
                    Name = name,
                    Salary = salary,
                    Position = position,
                    Department = department
                };
                if (input.Length == 5)
                {
                    var age = 0;
                    if (int.TryParse(input[4], out age))
                    {
                        employee.Age = age;
                    }
                    else
                    {
                        employee.Email = input[4];
                    }
                }
                else if (input.Length == 6)
                {
                    employee.Email = input[4];
                    employee.Age = int.Parse(input[5]);
                }
                if (employee.Email == null)
                {
                    employee.Email = "n/a";
                }
                if (employee.Age == 0)
                {
                    employee.Age = -1;
                }
                employees[department].Add(employee);
            }

            var highestAverageSalaryDepartment = employees.OrderByDescending(a => a.Value.Average(b => b.Salary)).First().Key;

            Console.WriteLine($"Highest Average Salary: {highestAverageSalaryDepartment}");

            foreach (var employee in employees[highestAverageSalaryDepartment].OrderByDescending(a => a.Salary))
            {
                Console.WriteLine($"{employee.Name} {employee.Salary:F2} {employee.Email} {employee.Age}");
            }
        }
    }
}
