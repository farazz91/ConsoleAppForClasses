using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForClasses
{
    class FullTimeEmployee : Employee
    {
        public int yearlySalary;

        public FullTimeEmployee()
        {
            Console.WriteLine("Child Class custructor for full time employee.");
        }

        public new void printDetails()
        {
            Console.WriteLine("FirstName: {0}", firstName);
            Console.WriteLine("LastName: {0}", lastName);
            Console.WriteLine("Salary: {0}",yearlySalary);
        }
    }
}
