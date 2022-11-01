# InterfacesMultipleInheritance

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Bir şirkette müdürler, işciler ve robotlar olmak üzere 3 çeşit 
çalışan bulunsun... */

namespace InterfacesMultipleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        interface IWorker
        {
            void Work();
            void Eat();
            void GetSalary();
        }

        class Manager : IWorker
        {
            public void Eat()
            {
                Console.WriteLine("Eat");
            }

            public void GetSalary()
            {
                Console.WriteLine("Get salary");
            }

            public void Work()
            {
                Console.WriteLine("Work");
            }
        }

        class Worker : IWorker
        {
            public void Eat()
            {
                Console.WriteLine("Eat");
            }

            public void GetSalary()
            {
                Console.WriteLine("Get salary");
            }

            public void Work()
            {
                Console.WriteLine("Work");
            }
        }

        class Robot : IWorker
        {
            public void Eat()
            {
                
            }

            public void GetSalary()
            {
                
            }
						
						
		
            public void Work()
            {
                Console.WriteLine("Work");
            }
        }

    }
}

// Hatalı kullanım !

// Robot bir çalışan yemek yemez ve maaş almaz...
```

---

```csharp
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* Bir şirkette müdürler, işciler ve robotlar olmak üzere 3 çeşit 
çalışan bulunsun... */

namespace InterfacesMultipleInheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IWorker[] workers = new IWorker[3]
            {
                new Manager(),
                new Worker(),
                new Robot()
            };

            foreach (var worker in workers)
            {
                worker.Work();
            }

            IEat[] eats = new IEat[2]
            {
                new Manager(),
                new Worker(),
            };

            foreach (var eat in eats)
            {
                eat.Eat();
            }   

            ISalary[] salaries = new ISalary[2]
            {
                new Manager(),
                new Worker(),
            };

            foreach (var salary in salaries)
            {
                salary.GetSalary();
            }

            Console.ReadLine();
        }
    }

        interface IWorker
        {
            void Work();
        }

        interface IEat
        {
            void Eat();
        }

        interface ISalary
        {
            void GetSalary();
        }

        class Manager : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                Console.WriteLine("Eat");
            }

            public void GetSalary()
            {
                Console.WriteLine("Get salary");
            }

            public void Work()
            {
                Console.WriteLine("Work");
            }
        }

        class Worker : IWorker, IEat, ISalary
        {
            public void Eat()
            {
                Console.WriteLine("Eat");
            }

            public void GetSalary()
            {
                Console.WriteLine("Get salary");
            }

            public void Work()
            {
                Console.WriteLine("Work");
            }
        }

        class Robot : IWorker
        {
            public void Work()
            {
                Console.WriteLine("Work");
            }
        }
}
```

![Untitled](img/Untitled.png)

Yukarıdaki interface kullanımı yazılım geliştirme açısından doğru olan kullanımdır. 

SOLID Prensiplerinden “Interface Segregarion” prensibine uygundur.

 

<aside>

📌 Class’lar birden fazla interface’den miras alabilir.

</aside>