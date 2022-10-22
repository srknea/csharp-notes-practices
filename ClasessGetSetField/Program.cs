using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasessGetSetField
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();

            customer.Id = 231;
            customer.FullName = "Serkan ISIK";
            customer.Age = 23;

            Customer customer2 = new Customer()
            {
                Id = 1023,
                FullName = "Emine ISIK",
                Age = 54
            };

            Console.WriteLine(customer.FullName);


            Console.WriteLine(customer2.FullName);

            Console.ReadLine();
        }
    }
}
