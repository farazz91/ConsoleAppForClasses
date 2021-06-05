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
        }
    }
}
