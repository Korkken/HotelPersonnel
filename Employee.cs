using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace HotelPersonnel
{
    internal class Employee : Person
    {

            public string JobTitle { get; set; }
            public string Department { get; set; }
            public Employee(string name, int age, string employeeId, DateTime startDate, decimal salary, string department, string jobTitle)
               : base(name, age, employeeId, startDate, salary)
            {
                Department = department;
                JobTitle = jobTitle;
            }
            public override void PrintInfo()
            {
                Console.WriteLine($"Namn: {Name}, Ålder: {Age}");
            }
            public override void Introduce()
            {
                Console.WriteLine($"Hej, mitt namn är {Name} och jag är {Age} år gammal.");
            }
            public void Work()
            {
                Console.WriteLine($"{Name} Arbetar som {JobTitle} på {Department}");
            }

        }
    
}
