using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PersonManager personManager = new PersonManager();

            /*
            Customer customer = new Customer
            {
                Id = 1,
                FirstName = "Aysegul",
                LastName = "ISIK",
                Address = "Hatay"
            };
            personManager.Add(customer);
            */

            personManager.Add(new Customer { Id = 1, FirstName = "Aysegul", LastName = "ISIK", Address = "Hatay" });

            personManager.Add(new Student { Id = 1, FirstName = "Serkan", LastName = "ISIK", Department = "Computer Engineering" });


            Console.ReadLine();
        }

        interface IPerson
        {
            // public vb. yazılmaz
            int Id { get; set; }
            string FirstName { get; set; }
            string LastName { get; set; }

        }

        class Customer:IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            //public int LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


            public string Address { get; set; }
        }

        class Student : IPerson
        {
            public int Id { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            

            public string Department { get; set; }
        }

        class PersonManager
        {
            /*
            public void Add(Customer customer)
            {
                Console.WriteLine(customer.Address);
            }

            public void Add(Student student)
            {
                Console.WriteLine(student.FirstName);
            }
            */


            // Yukarıdakileri yazmak yerine IPerson'u kullanabiliriz.
            public void Add(IPerson person)
            {
                Console.WriteLine(person.FirstName);

                /* 
                Fakat: Customer veya Student 'e özgü olan şeylere erişemeyiz...

                Console.WriteLine(person.Department);
                Console.WriteLine(person.Address);
                */
            }
        }

    }
}
