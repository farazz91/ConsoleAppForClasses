using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForClasses
{
    class Customer
    {
        string firstName;
        string lastName;

        public Customer(string firstName,string lastName)
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public Customer():this("No FirstName","No LastName")
        {
            Console.WriteLine("Default Custructor.");
        }
    public void PrintFullName()
        {
            Console.WriteLine("FirstName:{0} LastName:{1}",firstName,lastName);
        }
    } 
}
