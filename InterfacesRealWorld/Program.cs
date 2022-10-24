using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesRealWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();

            customerManager.Add(new OracleCustomerDal());
            //customerManager.Add(new SqlServerCustomerDal());

            Console.ReadLine();
        }
    }
}