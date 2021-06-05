using System;

namespace ConsoleAppForClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer("Sarfaraz","Ahmed");
            customer1.PrintFullName();

            Customer customer2 = new Customer();
            customer2.PrintFullName();

            Circle circle1 = new Circle(5);
            Console.WriteLine("Radius of circle is: {0}" ,circle1.calculateRadius().ToString());

            Circle circle2 = new Circle(9);
            Console.WriteLine("Radius of circle is: {0}", circle2.calculateRadius().ToString());

            Employee Emp1 = new Employee("Assigning value to base classs constructor");
            Emp1.firstName = "Sarfaraz";
            Emp1.lastName = "Ahmed";
            Emp1.printDetails();            

            FullTimeEmployee Femp1 = new FullTimeEmployee();
            Femp1.firstName = "Faraz";
            Femp1.lastName = "Khan";
            Femp1.yearlySalary = 10000;
            Femp1.printDetails();            

            PartTimeEmployee Pemp1 = new PartTimeEmployee();
            Pemp1.firstName = "Tom";
            Pemp1.lastName = "Jerry";
            Pemp1.hourlySalary = 500;
            Pemp1.printDetails();

            Employee emp2 = new FullTimeEmployee();
            emp2.firstName = "Sarfaraz";
            emp2.lastName = "Ahmed";
            
            emp2.printName();
            Employee emp3 = new PartTimeEmployee();
            emp3.firstName = "Faraz";
            emp3.lastName = "Ahmed";
            emp3.printName();

        }
    }
}
