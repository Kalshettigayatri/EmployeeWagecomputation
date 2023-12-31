﻿using EmpWageP04;

internal class Program
{
    public static void Main()
    {

        Console.WriteLine("Hello Fellow Learners!\nWelcome to Employee Wage Problem.\nEnter the index no. of the program you want to run.");
        Console.WriteLine("1.Basic Code\n2.Refactored Code\n3.For Multiple Companies");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1:
                employee search = new employee();
                search.EmployeeWage();
                break;
            case 2:
                EmployeeWageCalculator employeeWageCalculator1 = new EmployeeWageCalculator();
                EmployeeWageCalculator.ComputeEmployeeWage();
                break;
            case 3:
                EmployeeWageCalculator2 employeeWageCalculator2 = new EmployeeWageCalculator2();
                EmployeeWageCalculator2.ComputeEmployeeWage2("Company A", 20, 100, 20); // Company A's parameters
                EmployeeWageCalculator2.ComputeEmployeeWage2("Company B", 22, 110, 25); // Company B's parameters
                break;
            default:
                Console.WriteLine("Please Enter a Valid Index No.");
                break;
        }
        Console.ReadLine();
    }
}
