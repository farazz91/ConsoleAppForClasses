using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForClasses
{
    class Employee
    {
        public string firstName;
        public string lastName;

        public Employee():this("No Message")
        {
            Console.WriteLine("Base class custructor Default.");
        }

        public Employee(string message)
        {
            Console.WriteLine("Base class custructor.");
            Console.WriteLine(message);
        }

        public void printDetails()
        {
            Console.WriteLine("FirstName: {0}",firstName);
            Console.WriteLine("LastName: {0}", lastName);
        }
        public virtual void printName()
        {
            Console.WriteLine("Name: {0} {1}", firstName,lastName);
        }
    }
}
