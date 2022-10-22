using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasessGetSetProperty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            customer.Id = 231;
            customer.FirstName = "Serkan";
            customer.LastName = "ISIK";
            customer.Age = 23;

            Customer customer2 = new Customer()
            {
                Id = 1023,
                FirstName = "Emine",
                LastName = "ISIK",
                Age = 54
            };

            Console.WriteLine(customer.FirstName);
            Console.WriteLine(customer.LastName);

            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer2.LastName);

            Console.ReadLine();
        }
    }
}
