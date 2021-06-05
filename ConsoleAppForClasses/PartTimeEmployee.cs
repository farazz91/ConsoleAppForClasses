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
    }
}
