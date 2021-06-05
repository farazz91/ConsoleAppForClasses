using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppForClasses
{
    class Student
    {
        int id;
        string city;

        public int ID {
            set {
                this.id = value;
                    }
            get {
                return this.id;
            } 
        }
        public string City {
            set
            {
                this.city = value;
            }
            get { return this.city; 
            }          
        }

        public void PrintStudentDetails()
        {
            Console.WriteLine("Student ID: {0}",this.id);
            Console.WriteLine("Student City: {0}", this.city);
        }
    }
}
