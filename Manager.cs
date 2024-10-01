using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HotelPersonnel
{
    internal class Manager : Person
    {
        public string Department { get; set; }

        public Manager(string name, int age, string employeeId, DateTime startDate, decimal salary, string department)
            : base(name, age, employeeId, startDate, salary)
        {

            Department = department;
        }
        public override void PrintInfo()
        {
            Console.WriteLine($"Namn: {Name}, Ålder: {Age}");
        }
        public override void Introduce()
        {
            Console.WriteLine($"Hej, mitt namn är {Name} och jag är {Age} år gammal.");
        }
        public void HoldMeeting()
        {
            Console.WriteLine($"{Name} Håller ett personalmöte på hotellet");
        }
        public void PlanBudget()
        {
            Console.WriteLine($"{Name} Planerar budget för hotellet");
        }
    }
}
