﻿using DepartmentsEmployeesConsole.Data;
using DepartmentsEmployeesConsole.Models;
using System;

namespace DepartmentsEmployeesConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new EmployeeRepository();
            //var employees = repo.GetAllEmployees();

            //foreach (var employee in employees)
            //{
            //    Console.WriteLine($"{employee.FirstName} {employee.LastName} is in {employee.Department.DeptName}");
            //}


            //Console.WriteLine("Let's get an employee with the ID 2");

            //var employeeWithId2 = repo.GetEmployeeById(2);

            //Console.WriteLine($"Employee with Id 2 is {employeeWithId2.FirstName} {employeeWithId2.LastName}");

            Console.WriteLine("First Name");
            var firstName = Console.ReadLine();

            Console.WriteLine("Last Name");
            var lastName = Console.ReadLine();

            var newEmployee = new Employee()
            {
                FirstName = firstName,
                LastName = lastName,
                DepartmentId = 2
            };

            repo.CreateNewEmployee(newEmployee);
        }
    }
}
