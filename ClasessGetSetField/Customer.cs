using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasessGetSetField
{
    internal class Customer
    {
        //property
        public int Id { get; set; }

        //property kullanmak önerilir...

        //field - değişken 
        public string _fullName;
        public string FullName
        {
            get
            {
                return "Sayin " + _fullName;
            }
            set
            {
                _fullName = value;
            }
        }

        //property
        public int Age { get; set; }
    }
}
