using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void PrintName()
        {
            Console.WriteLine(this.FirstName + this.LastName);
        }
        public void CallDelegateFunction()
        {
            Message message = new Message(PrintMessage);
            message("hello Delegate");
        }
        public static void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }
    }

    class PartTimeEmployee : Employee
    {
        public int Salary { get; set; }
        public string Designation { get; set; }
        public void PrintSalaryAndDesignation()
        {
            Console.WriteLine("Employ Id: " + this.Id + " Salary of the Employee: " + this.Salary + " Designation: " + this.Designation);
        }
    }
    class FullTimeEmployee : Employee
    {
        public int Salary { get; set; }
        public string Designation { get; set; }
        public void PrintSalaryAndDesignation()
        {
            Console.WriteLine("Employ Id: " + this.Id + "Salary of the Employee" + this.Salary + "Designation: " + this.Designation);
        }
    }

    public delegate void Message(string message);

}
