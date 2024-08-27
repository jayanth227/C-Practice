// See https://aka.ms/new-console-template for more information
using ConsoleApp1;

Console.WriteLine("Hello, World!");

PartTimeEmployee pte = new PartTimeEmployee();
pte.FirstName = "Jayanth";
pte.LastName = "Reddy";
pte.Salary = 100000;
pte.Designation = "SDE";
pte.PrintSalaryAndDesignation();
pte.CallDelegateFunction();