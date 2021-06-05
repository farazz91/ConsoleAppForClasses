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
        }
    }
}
