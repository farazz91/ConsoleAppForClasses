using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForClasses
{
    class PartTimeEmployee : Employee
    {
        public int hourlySalary;

        public PartTimeEmployee():base("Assigning from chil class to base class.")
        {
            Console.WriteLine("Part time Employee custructor.");
        }
        public new void printDetails()
        {
            Console.WriteLine("FirstName: {0}", firstName);
            Console.WriteLine("LastName: {0}", lastName);
            Console.WriteLine("Salary: {0}", hourlySalary);
            base.printDetails();    //for explicitly calling base class meghod
        }
        public override void printName()
        {
            Console.WriteLine("Name: {0}", firstName);            
        }
    }
}
