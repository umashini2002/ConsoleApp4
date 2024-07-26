using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double BasaicSalary {  get; set; }
        public Employee(string Afirstname, string Alastname, double Abasicsalary)
        {
            FirstName = Afirstname;
            LastName = Alastname;
            BasaicSalary = Abasicsalary;
        }
        public void print(string Afirstname,string Alastname,double Abasicsalary)
        {
            Console.WriteLine($"Name = {FirstName} {LastName},Basic Salary = {BasicSalary}");
        }

    }
}
