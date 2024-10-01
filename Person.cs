using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelPersonnel
{
    internal class Person
    {
        public string Name;
        public int Age;
        public string EmployeeId;
        public DateTime StartDate;
        public decimal Salary;

        public Person(string name, int age, string employeeId, DateTime startDate, decimal salary)
        {
            Name = name;
            Age = age;
            EmployeeId = employeeId;
            StartDate = startDate;
            Salary = salary;
        }


        public virtual void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}, Ålder {Age}");
        }
        public virtual void Introduce()
        {
            Console.WriteLine($"Hej, mitt namn är {Name} och jag är {Age} år gammal.");
        }
        public virtual void DoWork()
        {
            Console.WriteLine($"");
        }
    }
}
